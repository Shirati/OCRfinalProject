﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using repositories.entities;
using repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories.repositories
{
    public class UserRepsitory : Ientity<User>
    {
        IContext _cotext;
        public UserRepsitory(IContext context)
        {
            _cotext = context;
        }
        public async Task<User> Add(User entity)
        {
            EntityEntry<User> newUser = _cotext.Users.Add(entity);
            await _cotext.SaveChangesAsync();
            return newUser.Entity;
        }

        public async Task Delete(int id)
        {
            _cotext.Users.Remove(_cotext.Users.Single(a => a.UserId == id));
            await _cotext.SaveChangesAsync();
        }

        public async Task<List<User>> GetAll()
        {
            return await _cotext.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _cotext.Users.SingleAsync(a => a.UserId == id);
        }

        public async Task<User> Update(User entity)
        {
            Delete(entity.UserId);
            return await Add(entity);
        }
    }
}
