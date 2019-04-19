﻿using AutoMapper;
using DAL.Interfaces;
using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DBNContext context) : base(context)
        {
        }

        public List<UserDTO> GetAll()
        {
            var users = (from u in context.Users
                         select u).ToList();

            return Mapper.Map<List<User>, List<UserDTO>>(users);
        }
    }
}