using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using C__MVCPrac.Models;
using System.ComponentModel;
using System.Web;

namespace C__MVCPrac.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.username = HttpContext.Session.GetString("username");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public ViewResult HelloWorld()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
