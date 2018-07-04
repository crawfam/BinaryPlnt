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

        public ActionResult Poem(int Id)
        {
            Poems p = new Poems();
            Poem poem = p.getPoem(Id);

            if (!poem.IsFirst)
            {
                ViewBag.PrevPoemId = p.getPoem(poem.PrevPoemId).Id;
            }
            if (!poem.IsLast)
            {
                ViewBag.NextPoemId = p.getPoem(poem.NextPoemId).Id;
            }


            //ViewBag.ImageName = p.getPoem(poem.Id).FileNameJpg;
            //ViewBag.Title = poem.Name;
            //ViewBag.IsLast = poem.IsLast;
            //ViewBag.IsFirst = poem.IsFirst;
            
            return View(poem.FileName, poem);

        }
    }
}