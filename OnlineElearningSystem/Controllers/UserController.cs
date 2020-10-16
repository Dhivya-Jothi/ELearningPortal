using OnlineElearningSystem.BL;
using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using OnlineElearningSystem.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineElearningSystem.Controllers
{
	[HandleError]	
    public class UserController : Controller
    {
		public static UserDetail role { get; set; }
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
		public ActionResult CreateUser(UserDetailModel userDetailModel)
		{
			
			IEnumerable<UserDetail> detail = UserRepository.SignUp();
			if (ModelState.IsValid)
			{

				var newUser = AutoMapper.Mapper.Map<UserDetailModel, UserDetail>(userDetailModel);
				//UserDetail userDetail = new UserDetail
				//{
				//	userId = userDetailModel.userId,
				//	userName = userDetailModel.userName,
				//	gender = userDetailModel.gender,
				//	confirmPassword = userDetailModel.confirmPassword,
				//	mobileNumber = userDetailModel.mobileNumber,
				//	mailId = userDetailModel.mailId,
				//	dateOfBirth = userDetailModel.dateOfBirth,
				//	mediumOfStudy = userDetailModel.mediumOfStudy,
				//	userRcvcole = "User",
				//};
				User user = new User();
				user.SignUp(newUser);
			}
			return View();
		}
		[HttpGet]
		public ActionResult Login()
		{
			return View();

		}
		[HttpPost]
		[ActionName("Login")]
		public ActionResult Login(LoginModel loginModel)
		{

			if (ModelState.IsValid)
			{
				UserDetail userDetail = new UserDetail
				{
					userName = loginModel.userName,
					confirmPassword = loginModel.password,

				};
				User user = new User();
				role = user.Login(userDetail);
				return RedirectToAction("Home", role);


				//if (user.Login(userDetail) == "Admin")
				//{
				//	return RedirectToAction("Handle_User", "Admin");
				//}
				//else if (user.Login(userDetail) == "User")
				//{
				//	return RedirectToAction("");
				//}
				//else
				//{
				//	ViewBag.Message = "Username or Password incorrect";
				//	return RedirectToAction("SignUp");
				//}
			}
				return View();
		}
		public ActionResult Home()
		{
			return View();
		}
		[CustomError]
		public ActionResult Test()
		{
			throw new Exception("Error have been occured");
		}

	}
}