using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FWDSchool.Web.Models;

namespace FWDSchool.Web.Controllers;

public class TutorialSectionController : Controller
{
    [HttpGet]
    public IActionResult Add()
    {
        var db = new FWDSchoolDb();
        var tutorials = db.Tutorials.ToList();
        ViewData["tutorials"] = tutorials;
        
        return View();
    }

    [HttpPost]
    public IActionResult Add(TutorialSection section)
    {
        // Save this tutorialsection to db
        var db = new FWDSchoolDb();
        section.LastUpdated = DateTime.Now;
        db.TutorialSections.Add(section);
        db.SaveChanges();

        return Created();
    }
}
