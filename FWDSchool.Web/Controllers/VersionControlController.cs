using Microsoft.AspNetCore.Mvc;

public class VersionControlController : Controller
{
    
    public IActionResult Index()
    {
        var db = new FWDSchoolDb();
        var tutorials = db.Tutorials.Where(x => x.Type == "VersionControl").ToList();  // Select * from Tutorials where condition is applied
        return View(tutorials);

    }
    public IActionResult About()
    {
        return View();
    }

    
}
