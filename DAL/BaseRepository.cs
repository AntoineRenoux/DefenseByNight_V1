﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        protected readonly DBNContext context;

        public BaseRepository(DBNContext context)
        {
            this.context = context;
        }
    }
}
