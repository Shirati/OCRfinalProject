using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using repositories.entities;
using repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories.repositories
{
    public class ActionTypeRepository:Ientity<ActionType>
    {
        IContext _cotext;
        public ActionTypeRepository(IContext context)
        {
            _cotext = context;
        }
        public async Task<ActionType> Add(ActionType entity)
        {
            EntityEntry<ActionType> newEntity = _cotext.actionTypes.Add(entity);
            await _cotext.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task Delete(int id)
        {
            _cotext.actionTypes.Remove(_cotext.actionTypes.Single(a => a.ActionTypeId == id));
            await _cotext.SaveChangesAsync();
        }

        public async Task<List<ActionType>> GetAll()
        {
            return await _cotext.actionTypes.ToListAsync();
        }

        public async Task<ActionType> GetById(int id)
        {
            return await _cotext.actionTypes.SingleAsync(a => a.ActionTypeId == id);
        }

        public async Task<ActionType> Update(ActionType entity)
        {
            Delete(entity.ActionTypeId);
            return await Add(entity);
        }
    }
}
