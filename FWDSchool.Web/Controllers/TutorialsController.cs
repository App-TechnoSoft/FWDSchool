using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FWDSchool.Web.Models;

namespace FWDSchool.Web.Controllers;

public class TutorialsController : Controller
{
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Tutorial tutorial)
    {
        // Save this tutorial to db
        var db = new FWDSchoolDb();
        tutorial.Published = DateTime.Now;
        db.Tutorials.Add(tutorial);
        db.SaveChanges();

        return RedirectToAction("Index", "Frontend");
    }
}