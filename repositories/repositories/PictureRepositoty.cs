using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using repositories.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using repositories.interfaces;

namespace repositories.repositories
{
    public class PictureRepositoty:Ientity<Picture>
    {
        IContext _cotext;
        public PictureRepositoty(IContext context)
        {
            _cotext = context;
        }
        public async Task<Picture> Add(Picture entity)
        {
            EntityEntry<Picture> newEntity= _cotext.Pictures.Add(entity);
            await _cotext.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task Delete(int id)
        {
            _cotext.Pictures.Remove(_cotext.Pictures.Single(a => a.PictureId == id));
            await _cotext.SaveChangesAsync();
        }

        public async Task<List<Picture>> GetAll()
        {
            return await _cotext.Pictures.ToListAsync();
        }

        public async Task<Picture> GetById(int id)
        {
            return await _cotext.Pictures.SingleAsync(a => a.PictureId == id);
        }

        public async Task<Picture> Update(Picture entity)
        {
            Delete(entity.PictureId);
            return await Add(entity);
        }
    }
}
