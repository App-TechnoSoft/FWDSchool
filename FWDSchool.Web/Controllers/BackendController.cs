using Microsoft.AspNetCore.Mvc;


public class BackendController : Controller
{
    
    public IActionResult Index()
    {
         var db = new FWDSchoolDb();
        var tutorials = db.Tutorials.Where(x => x.Type == "Backend").ToList();  // Select * from Tutorials
        return View(tutorials);
    }

    
}
