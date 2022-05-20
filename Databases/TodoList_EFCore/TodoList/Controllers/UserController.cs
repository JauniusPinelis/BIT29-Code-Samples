using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.Services;

namespace TodoList.Controllers;

public class UserController : Controller
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    public IActionResult Index()
    {
        var users = _userService.GetAll();
        return View(users);
    }

    [HttpGet]
    public IActionResult Add()
    {
        var user = new User();
        return View(user);
    }

    [HttpPost]
    public IActionResult Add(User user)
    {
        _userService.Add(user);
        return RedirectToAction("Index");
    }
}

