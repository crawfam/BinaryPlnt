using BinaryPlanet.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace BinaryPlanet.Controllers
{
    public class HomeController : Controller
    {

        ApplicationDbContext _context = new ApplicationDbContext();

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
            ViewBag.Title = "Table Of Contents";
            return View("TableOfContents");
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