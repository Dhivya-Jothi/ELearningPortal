using OnlineElearningSystem.BL;
using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using OnlineElearningSystem.Models;
using System.Collections.Generic;

using System.Web.Mvc;

namespace OnlineElearningSystem.Controllers
{
    public class CourseController : Controller
    {
		CourseBL courseBl = new CourseBL();
		CourseRepositry courseRepositry = new CourseRepositry();
		// GET: Course
		public ActionResult Index()
        {
            return View();
        }

		[HttpGet]
		public ActionResult CreateCourse()
		{
			ViewBag.Category = new SelectList(courseBl.GetCategory(), "categoryId", "categoryName");
			return View();
		}
		[HttpPost]
		public ActionResult CreateCourse(CourseModel courseModel)
		{
			ViewBag.Category = new SelectList(courseBl.GetCategory(), "categoryId", "categoryName");
			if (ModelState.IsValid)
			{

				var newUser = AutoMapper.Mapper.Map<CourseModel, Course>(courseModel);
				CourseBL course = new CourseBL();
				course.AddCourse(newUser);
			}
			return View();
		}
		IEnumerable<Course> CourseList;
		public ActionResult Handle_Course()
		{
			CourseList = courseRepositry.ViewCourse();
			return View(CourseList);
		}

		[HttpGet]
		public ActionResult Edit(Course course)
		{
			ViewBag.Category = new SelectList(courseBl.GetCategory(), "categoryId", "categoryName");
			Course courseDetail = courseRepositry.FetchData(course.courseId);
			return View(courseDetail);
		}
		[HttpPost]
		public ActionResult Edit(CourseModel courseModel)
		{

			Course course = new Course();
			course.courseName = courseModel.courseName;
			course.courseId = courseModel.courseId;
			course.categoryId = courseModel.categoryId;
			courseRepositry.UpdateCourse(course);
			return RedirectToAction("Handle_Course");
		}

		public ActionResult Delete(int id)
		{
			courseRepositry.DeleteCourse(id);
			return RedirectToAction("Handle_Course");
		}

	}
}