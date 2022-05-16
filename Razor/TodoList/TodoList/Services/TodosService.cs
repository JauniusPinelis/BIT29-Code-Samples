using System.Collections.Generic;
using System.Linq;
using TodoList.Models;

namespace TodoList.Services
{
    public class TodosService
    {
        public TodosService()
        {
        }

        private List<Todo> _todos = new List<Todo>()
        {
            new Todo()
            {
                Category = "Studying",
                CreatedUtc = System.DateTime.Now,
                Name = "Study Programming"
            },
             new Todo()
            {
                Category = "House",
                CreatedUtc = System.DateTime.Now,
                Name = "Clean room"
            }
        };

        public List<Todo> GetAll()
        {
            return _todos;
        }

        public void Add(Todo todo)
        {
            _todos.Add(todo);
        }

        public void Delete(string name)
        {
            _todos = _todos.Where(t => t.Name != name).ToList();
        }
    }
}
