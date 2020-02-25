using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using System;
using System.Collections.Generic;
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
		[HttpGet]
		public ActionResult SignUp()
		{
			return View();
		
		}
		[HttpPost]
		[ActionName("SignUp")]
		public ActionResult CreateUser(UserDetail userDetail)
		{
			IEnumerable<UserDetail> detail = UserRespositry.SignUp();
			user.AddUser(userDetail);
			if (ModelState.IsValid)
			{
				
				return RedirectToAction("Login");
			}
			return View();
		}
		public ActionResult Login(UserDetail userDetail)
		{
			return View();
		}
	}
}