using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FWDSchool.Web.Models;

namespace FWDSchool.Web.Controllers;

public class VersionControlController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
