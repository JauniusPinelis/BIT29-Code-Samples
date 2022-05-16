using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
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
            Todo todo = new Todo(); //Passing empty model
            return View(todo);
        }

        [HttpPost]
        public IActionResult Add(Todo todo)
        {
            _todosService.Add(todo);
            return RedirectToAction("Index");
        }
    }
}
