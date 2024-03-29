﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class PermissionRepository : Ientity<Permission>
    {
        IContext _cotext;
        public PermissionRepository(IContext context)
        {
            _cotext = context;
        }
        public async Task<Permission> Add(Permission entity)
        {
            EntityEntry<Permission> newEntity = _cotext.Permissions.Add(entity);
            await _cotext.SaveChangesAsync();
            return newEntity.Entity;
        }

        public async Task Delete(int id)
        {
            _cotext.Permissions.Remove(_cotext.Permissions.Single(a => a.PermissionId == id));
            await _cotext.SaveChangesAsync();
        }

        public async Task<List<Permission>> GetAll()
        {
            return await _cotext.Permissions.ToListAsync();
        }

        public async Task<Permission> GetById(int id)
        {
            return await _cotext.Permissions.SingleAsync(a => a.PermissionId == id);
        }

        public async Task<Permission> Update(Permission entity)
        {
            Delete(entity.PermissionId);
            return await Add(entity);
        }
    }
}
