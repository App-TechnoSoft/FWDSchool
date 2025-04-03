using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FWDSchool.Web.Models;

namespace FWDSchool.Web.Controllers;

public class FrontendControllerr : Controller
{
     public IActionResult index()
    {
        return View();
    }

}