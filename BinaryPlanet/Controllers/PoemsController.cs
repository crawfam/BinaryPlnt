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
            Poems p = new Poems();
            Poem poem = p.getPoem(fileName);

            ViewBag.NextPoemFileName = poem.NextPoemFileName;
            ViewBag.ImageName = poem.FileName;
            ViewBag.Title = poem.Name;
            ViewBag.IsLast = poem.IsLast;
            
            return View(fileName);
        }
    }
}