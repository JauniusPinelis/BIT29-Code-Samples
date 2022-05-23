using System.Collections.Generic;
using System.Linq;
using TodoList.Data;
using TodoList.Models;

namespace TodoList.Services
{
    public class TodosService
    {
        private DataContext _dataContext;

        public TodosService(DataContext dataContext)
        {
            _dataContext = dataContext;
            // through dependency injection
        }

        public List<Todo> GetAll()
        {
            return _dataContext.Todos.ToList();
        }

        public void Add(Todo todo)
        {
            _dataContext.Todos.Add(todo);
            _dataContext.SaveChanges();
        }

        public void Delete(string name)
        {
            var todo = _dataContext.Todos.FirstOrDefault(t => t.Name == name);
            _dataContext.Todos.Remove(todo);
            _dataContext.SaveChanges();
        }
    }
}
