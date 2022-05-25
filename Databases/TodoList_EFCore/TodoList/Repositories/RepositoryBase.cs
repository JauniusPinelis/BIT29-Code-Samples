using System.Collections.Generic;
using System.Linq;
using TodoList.Data;
using TodoList.Models.Base;

namespace TodoList.Repositories
{
    public class RepositoryBase<T>
        where T : Entity
    {
        protected DataContext _dataContext;

        public List<T> GetAll()
        {
            return _dataContext.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            entity.CreatedUtc = System.DateTime.Now;
            _dataContext.Set<T>().Add(entity);
            _dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dataContext.Set<T>().FirstOrDefault(t => t.Id == id);
            _dataContext.Set<T>().Remove(entity);
            _dataContext.SaveChanges();
        }
    }
}
