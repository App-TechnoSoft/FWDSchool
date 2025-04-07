using Microsoft.AspNetCore.Mvc;


public class BackendController : Controller
{
    
    public IActionResult Index()
    {
         var db = new FWDSchoolDb();
        var tutorials = db.Tutorials.Where(x => x.Type == TutorialType.Backend).ToList();  
        return View(tutorials);
    }

    
}
