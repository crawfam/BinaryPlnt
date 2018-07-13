using BinaryPlanet.Models;
using BinaryPlanet.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace BinaryPlanet.Controllers
{
    [Authorize]
    public class PoemsController : Controller
    {

        private readonly ApplicationDbContext _context;


        public PoemsController()
        {
            _context = new ApplicationDbContext();
        }


        // see: http://www.dotnet-stuff.com/tutorials/aspnet-mvc/how-to-render-different-layout-in-asp-net-mvc

        public ActionResult Poem(int Id)
        {

            if (Request.IsAuthenticated)
            {
                string userId = User.Identity.GetUserId();
                BPUser bpUser = _context.BPUsers.Where(s => s.AppId == userId).SingleOrDefault();
                System.Web.HttpContext.Current.Session["UserName"] = bpUser.FirstName + " " + bpUser.LastName;
            }

            PoemViewModel poemViewModel = new PoemViewModel(Id);

            return View(poemViewModel.FileNameView, "_Layout", poemViewModel);

        }
    }
}