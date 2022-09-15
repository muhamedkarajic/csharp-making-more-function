using System.Linq;

namespace Demo
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        void Add(T obj);
    }
}
