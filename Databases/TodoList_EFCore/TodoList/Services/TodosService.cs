using System.Collections.Generic;
using TodoList.Dtos;
using TodoList.Models;
using TodoList.Repositories;

namespace TodoList.Services
{
    public class TodosService
    {
        private TodoRepository _todoRepository;

        public TodosService(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public List<Todo> GetAll()
        {
            return _todoRepository.GetAll();
        }

        public void Delete(int id)
        {
            _todoRepository.Delete(id);
        }

        public void Add(CreateTodoDto createTodoDto)
        {
            // map dto to entity;
            Todo todo = new Todo
            {
                Name = createTodoDto.Todo.Name,
                Category = createTodoDto.Todo.Category
            };

            _todoRepository.Add(todo);
        }
    }
}
