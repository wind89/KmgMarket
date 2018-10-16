using System;
using System.Collections.Generic;
using System.Text;

namespace EMarket.DAL.Base
{
    public abstract class BaseRepository
    {
        public BaseRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        protected ApplicationDbContext Context; 
    }
}
