using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryPlanet.Models;
using System.Web.Mvc;

namespace BinaryPlanet.Controllers
{
    [Authorize]
    public class PoemsController : Controller
    {

        // see: http://www.dotnet-stuff.com/tutorials/aspnet-mvc/how-to-render-different-layout-in-asp-net-mvc

        public ActionResult Poem(string fileName)
        {
            Poem p = new Poem();
            PoemFileNames poemNames = p.getPoem(fileName);

            ViewBag.NextPoemFileName = poemNames.NextPoemFileName;
            ViewBag.ImageName = poemNames.FileName;
            ViewBag.Title = poemNames.Name;
            ViewBag.IsLast = poemNames.IsLast;
            
            return View(fileName);
        }
    }
}