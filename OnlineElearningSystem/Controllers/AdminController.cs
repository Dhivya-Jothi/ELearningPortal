using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using OnlineElearningSystem.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineElearningSystem.Controllers
{
	public class AdminController : Controller
	{
		// GET: Admin
		UserRepository userRepository = new UserRepository();
		public ActionResult Index()
		{
			return View();
		}


		IEnumerable<UserDetail> userList;
		public ActionResult Handle_User()
		{
			userList = userRepository.ViewUser();
			return View(userList);
		}

		[HttpGet]
		public ActionResult Edit(UserDetail userDetail)
		{
			UserDetail user = userRepository.FetchData(userDetail.userId);
			return View(user);
		}
		[HttpPost]
		[ActionName("Edit")]
		public ActionResult EditUser(UserDetailModel userDetailModel)
		{

			UserDetail userDetail = new UserDetail();
			userDetail.userId = userDetailModel.userId;
			userDetail.userName = userDetailModel.userName;
			userDetail.gender = userDetailModel.gender;
			userDetail.confirmPassword = userDetailModel.confirmPassword;
			userDetail.mobileNumber = userDetailModel.mobileNumber;
			userDetail.mailId = userDetailModel.mailId;
			userDetail.dateOfBirth = userDetailModel.dateOfBirth;
			userDetail.mediumOfStudy = userDetailModel.mediumOfStudy;
			userDetail.userRole = userDetailModel.userRole;
			userRepository.UpdateUser(userDetail);

			return RedirectToAction("Handle_User");
		}
		public ActionResult Delete(UserDetail user)
		{
			UserDetail userDetail = new UserDetail();
			userRepository.DeleteUser(user);
			return RedirectToAction("Handle_User");
		}
	}
}