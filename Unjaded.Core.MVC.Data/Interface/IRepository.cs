using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unjaded.Core.MVC.Data
{
    public interface IRepository<T>
    {
        T Get<Tkey>(Tkey id);
        T Get<TKey, Ukey>(TKey paramOne, Ukey paramTwo);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        IQueryable<T> AllActiveItems();
        IEnumerable<T> GetInfo();
        List<T> ActiveItems();
        IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        void Save();
    }
}
