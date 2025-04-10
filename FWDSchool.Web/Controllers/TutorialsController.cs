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
        var image = tutorial.File;
        // Save avatar to physical folder
        var fileName = $"{Guid.NewGuid()}_{image.FileName}"; //4ea97773c-e77e-4c3c-a075-c9asdf_image.jpg
        var appFolder = Directory.GetCurrentDirectory();
        var imageFolderPathRelative = $"/images/tutorialimages/{fileName}";
        var imageFolderPathAbsolute = appFolder + "/wwwroot/" + imageFolderPathRelative;

        var avatar = System.IO.File.Create(imageFolderPathAbsolute);
        image.CopyTo(avatar);
        avatar.Close();
        
        // Save this tutorial to db
        var db = new FWDSchoolDb();
        tutorial.Published = DateTime.Now;
        tutorial.ImagePath = imageFolderPathRelative;
        db.Tutorials.Add(tutorial);
        db.SaveChanges();

        return RedirectToAction("Index", "Frontend");
    }

    public IActionResult Sections(int id)
    {
        var db = new FWDSchoolDb();
        var sections = db.TutorialSections.Where(x => x.TutorialId == id).ToList();
        return View(sections);
    }
}