using BinaryPlanet.Models;
using BinaryPlanet.ViewModels;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BinaryPlanet.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        public HomeController() => _context = new ApplicationDbContext();


        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                string userId = User.Identity.GetUserId();
                BPUser bpUser = _context.BPUsers.Where(s => s.AppId == userId).SingleOrDefault();
                System.Web.HttpContext.Current.Session["UserName"] = bpUser.FirstName + " " + bpUser.LastName;
            }

            return View();
        }

        public ActionResult TableOfContents()
        {

            TableOfContentsViewModel poems;

            if (Request.IsAuthenticated)
            {
                string userId = User.Identity.GetUserId();
                int BPUserId = _context.BPUsers.Where(s => s.AppId == userId).SingleOrDefault().Id;
                poems = new TableOfContentsViewModel(BPUserId);
            }
            else
            { 
                poems = new TableOfContentsViewModel();
            }



            ViewBag.Title = "Table Of Contents";
            return View("TableOfContents", poems);
        }

        public ActionResult Reset()
        {


            /////////////////////////////////////////////


            //foreach (Poem p in _context.Poems)
            //{
            //     p.Sequence = p.Sequence * 100;                
            //}

            //_context.SaveChanges();


            //////////////////////////////////////////////




            TableOfContentsViewModel poems;

            if (Request.IsAuthenticated)
            {
                string userId = User.Identity.GetUserId();
                int BPUserId = _context.BPUsers.Where(s => s.AppId == userId).SingleOrDefault().Id;

                foreach (BPUserPoems userPoem in _context.BPUserPoems.Where(p => p.BPUserId == BPUserId))
                {
                    _context.BPUserPoems.Remove(userPoem);
                }

                _context.SaveChanges();


                poems = new TableOfContentsViewModel(BPUserId);
            }
            else
            {
                poems = new TableOfContentsViewModel();
            }


            ViewBag.Title = "Table Of Contents";
            return View("TableOfContents", poems);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}