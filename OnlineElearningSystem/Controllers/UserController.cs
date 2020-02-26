using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineElearningSystem.Controllers
{
	[HandleError]	
    public class UserController : Controller
    {
		UserRespositry userRepositry=new UserRespositry();
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
			if (ModelState.IsValid)
			{
				UserRespositry.SignUp();
				userRepositry.AddUser(userDetail);
				return RedirectToAction("Login");
			}
			return View();
		}
		public ActionResult Login(UserDetail userDetail)
		{
			return View();
		}
		[ErrorHandling]
		public ActionResult Test()
		{
			throw new Exception("Error have been occured");
		}
	}
}