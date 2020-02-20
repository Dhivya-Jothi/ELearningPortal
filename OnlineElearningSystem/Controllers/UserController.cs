using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineElearningSystem.Controllers
{
	
    public class UserController : Controller
    {
		UserRespositry user=new UserRespositry();
		public ActionResult Index()
        {
            return View();
        }
		public ActionResult SignUp()
		{
			return View();
		}
		[HttpPost]
		[ActionName("SignUp")]
		public ActionResult CreateUser()
		{
			UserDetail userDetail = new UserDetail();
			TryUpdateModel(userDetail);
			user.AddUser(userDetail);
			TempData["Message"] = "User Detail added";
			return RedirectToAction("Index");
		}
		public ActionResult Login()
		{
			return View();
		}
	}
}