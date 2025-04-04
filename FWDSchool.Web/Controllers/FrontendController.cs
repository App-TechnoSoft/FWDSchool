using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FWDSchool.Web.Models;

namespace FWDSchool.Web.Controllers;

public class FrontendController : Controller
{
     public IActionResult Index()
    {
        return View();
    }

}
