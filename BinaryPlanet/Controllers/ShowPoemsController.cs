using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BinaryPlanet.Controllers
{
    [Authorize]
    public class ShowPoemsController : Controller
    {

        // see: http://www.dotnet-stuff.com/tutorials/aspnet-mvc/how-to-render-different-layout-in-asp-net-mvc

        public ActionResult Poem(string fileName)
        {
            ViewBag.ImageName = fileName;
            ViewBag.Title = fileName.Replace("_", " ");
            return View(fileName);
        }
    }
}