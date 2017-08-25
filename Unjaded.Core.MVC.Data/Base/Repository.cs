using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Unjaded.Core.MVC.Data.Base
{
    public abstract class Repository<T> : IRepository<T>
        where T : ModelBase, IModel
    {
        protected DbContext Context;
        protected DbSet<T> DbSet;

        public Repository(IDataContext context)
        {
            Context = context as DbContext;
            DbSet = Context.Set<T>();
        }
    }
}
