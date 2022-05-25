using Microsoft.AspNetCore.Mvc;
using TodoList.Dtos;
using TodoList.Services;

namespace TodoList.Controllers
{
    public class TodoController : Controller
    {
        private TodosService _todosService;
        private UserService _userService;

        public TodoController(TodosService todosService, UserService userService)
        {
            _todosService = todosService;
            _userService = userService;
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
            todo.Todo = new Models.Todo();
            todo.Users = _userService.GetAll();
            return View(todo);
        }

        [HttpPost]
        public IActionResult Add(CreateTodoDto createTodo)
        {
            _todosService.Add(createTodo);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _todosService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
