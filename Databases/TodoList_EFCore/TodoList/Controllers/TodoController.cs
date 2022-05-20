using Microsoft.AspNetCore.Mvc;
using TodoList.Dtos;
using TodoList.Services;

namespace TodoList.Controllers
{
    public class TodoController : Controller
    {
        private TodosService _todosService;

        public TodoController(TodosService todosService)
        {
            _todosService = todosService;
        }

        public IActionResult Index()
        {
            var todos = _todosService.GetAll();
            return View(todos);
        }

        [HttpGet]
        public IActionResult Add()
        {
            CreateTodoDto todo = new CreateTodoDto(); //Passing empty model
            return View(todo);
        }

        [HttpPost]
        public IActionResult Add(CreateTodoDto createTodo)
        {
            _todosService.Add(createTodo.Todo);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string name)
        {
            _todosService.Delete(name);
            return RedirectToAction("Index");
        }
    }
}
