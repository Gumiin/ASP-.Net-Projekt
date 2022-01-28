using System.Linq.Expressions;

namespace ASP_Shop.Services
{
    public interface IRepository<T> where T : class
    {
        //T-category
        T GetFirstOrDefault(Expression<Func<T,bool>>filter);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);

    }
}
