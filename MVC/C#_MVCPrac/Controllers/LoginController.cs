using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using C__MVCPrac.Models;
using System.ComponentModel;
using System.Web;

namespace C__MVCPrac.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    public IActionResult LoginScreen()
    {
        return View();
    }

    public IActionResult LoginStronglyScreen()
    {
        return View();
    }

    [HttpPost]
    public IActionResult LoginScreenPost(string username, string password)
    {
        HttpContext.Session.SetString("username",username);
        // Weakly typed Form
        
        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public IActionResult StrongLoginPost(LoginViewModel login)
    {
        HttpContext.Session.SetString("username",login.Username);
        // Weakly typed Form
        
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.SetString("username","");
        // Weakly typed Form
        
        return RedirectToAction("LoginScreen", "Login");
    }

    public IActionResult UserDetail()
    {
        var user = new LoginViewModel();
        return View(user);
    }

    public IActionResult UserList()
    {
        var users = new List<LoginViewModel>()
        {
            new LoginViewModel(){Username="hehe",Password="hoho" },
            new LoginViewModel(){Username="123123",Password="hoho" },
            new LoginViewModel(){Username="asddd",Password="hoho" },
        };
        return View(users);
    }

    



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
