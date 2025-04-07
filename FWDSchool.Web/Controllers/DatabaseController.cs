using Microsoft.AspNetCore.Mvc;


public class DatabaseController : Controller
{
    
    public IActionResult Index()
    {
        var db = new FWDSchoolDb();
        var tutorials = db.Tutorials.Where(x => x.Type == TutorialType.Database).ToList();  
        return View(tutorials);
      
    }

    
}
