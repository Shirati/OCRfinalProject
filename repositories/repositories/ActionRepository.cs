using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using repositories.entities;
using repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = repositories.entities.Action;

namespace repositories.repositories
{
    public class ActionRepository:Ientity<Action>
    {
        IContext _cotext;
        public ActionRepository(IContext context)
        {
            _cotext = context;
        }
        public async Task<Action> Add(Action entity)
        {
            EntityEntry<Action> newEntity = _cotext.Actions.Add(entity);
            await _cotext.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task Delete(int id)
        {
            _cotext.Actions.Remove(_cotext.Actions.Single(a => a.ActionId == id));
            await _cotext.SaveChangesAsync();
        }

        public async Task<List<Action>> GetAll()
        {
            return await _cotext.Actions.ToListAsync();
        }

        public async Task<Action> GetById(int id)
        {
            return await _cotext.Actions.SingleAsync(a => a.ActionId == id);
        }

        public async Task<Action> Update(Action entity)
        {
            Delete(entity.ActionId);
            return await Add(entity);
        }
    }
}
