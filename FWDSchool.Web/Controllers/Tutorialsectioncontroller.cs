using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FWDSchool.Web.Models;

namespace FWDSchool.Web.Controllers;

public class TutorialSectionController : Controller
{
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(TutorialSection tutorial)
    {
        // Save this tutorial to db
        var db = new FWDSchoolDb();
        tutorial.LastUpdated = DateTime.Now;
        db.TutorialSections.Add(tutorial);
        db.SaveChanges();

        return RedirectToAction("Index", "Frontend");
    }
}
