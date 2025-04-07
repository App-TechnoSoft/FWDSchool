using Microsoft.AspNetCore.Mvc;


public class DatabaseController : Controller
{
    
    public IActionResult Index()
    {
        var db = new FWDSchoolDb();
        var tutorials = db.Tutorials.Where(x => x.Type == "Database").ToList();  // Select * from Tutorials
        return View(tutorials);
      
    }

    
}
