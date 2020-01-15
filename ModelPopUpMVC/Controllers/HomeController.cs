using ModelPopUpMVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ModelPopUpMVC.Controllers
{
    public class HomeController : Controller
    {
        //FriendsContext db = new FriendsContext();
        List<FriendsInfo> friendsList = new List<FriendsInfo>
        {
            new FriendsInfo{Id=1,Name="Narinder Gupta", Mobile = "123456789", Address = "123 Main Rd"},
            new FriendsInfo{Id=2,Name="Kelly Greene", Mobile = "123456789", Address = "123 Main Rd"},
            new FriendsInfo{Id=3,Name="Frank Johnson", Mobile = "123456789", Address = "123 Main Rd"},
            new FriendsInfo{Id=4,Name="Todd Andrews", Mobile = "123456789", Address = "123 Main Rd"},
        };
        public ActionResult Index()
        {
            return View(friendsList);
        }

        public ActionResult Details(int id)
        {
            FriendsInfo friendsInfo = new FriendsInfo();
            friendsInfo = friendsList.Find(f=>f.Id == id);
            return PartialView("PartialDetail",friendsInfo);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}