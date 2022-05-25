using TodoList.Data;
using TodoList.Models.Base;

namespace TodoList.Services.Base
{
    public class BaseService<T>
        where T : Entity
    {
        protected DataContext _dataContext;

        public BaseService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(T entity)
        {
            entity.CreatedUtc = System.DateTime.Now;
            _dataContext.Set<T>().Add(entity);
            _dataContext.SaveChanges();
        }
    }
}
