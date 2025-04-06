using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FWDSchool.Web.Models;

namespace FWDSchool.Web.Controllers;

public class FrontendController : Controller
{
    public IActionResult Index()
    {
        var db = new FWDSchoolDb();
        var tutorials = db.Tutorials.Where(x => x.Type == "Frontend").ToList();  // Select * from Tutorials
        return View(tutorials);
    }

    public IActionResult Html()
    {
        var db = new FWDSchoolDb();
        var tutorials = db.Tutorials.ToList();  // Select * from Tutorials
        return View(tutorials);
    }

}
