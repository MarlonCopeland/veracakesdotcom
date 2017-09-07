using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Unjaded.Core.MVC;
using System.Linq.Expressions;

namespace Unjaded.Core.MVC.Data
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

        public List<T> ActiveItems()
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> AllActiveItems()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get<Tkey>(Tkey id)
        {
            throw new NotImplementedException();
        }

        public T Get<TKey, Ukey>(TKey paramOne, Ukey paramTwo)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetInfo()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
