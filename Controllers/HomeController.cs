using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HDK700.Models;

namespace HDK700.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(String FullName, String Email)
    {
        ViewBag.name = "Cập Nhật Thông Tin:" + " " + FullName + " " + Email;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
