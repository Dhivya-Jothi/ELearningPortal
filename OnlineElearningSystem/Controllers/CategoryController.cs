using OnlineElearningSystem.BL;
using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using OnlineElearningSystem.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineElearningSystem.Controllers
{
    public class CategoryController : Controller
    {
		CourseBL course = new CourseBL();
		CourseRepositry courseRepositry = new CourseRepositry();
		CategoryRepositry categoryRepositry = new CategoryRepositry();
		// GET: Category
		public ActionResult Index()
        {
            return View();
        }
		[HttpGet]
		public ActionResult CreateCategory()
		{
			return View();
		}
		[HttpPost]
		public ActionResult CreateCategory(CategoryModel categoryModel)
		{
			if (ModelState.IsValid)
			{

				var newUser = AutoMapper.Mapper.Map<CategoryModel, Category>(categoryModel);
				course.AddCategory(newUser);
			}
			return View();
		}

		IEnumerable<Category> CategoryList;
		public ActionResult Handle_Category()
		{
			CategoryList = categoryRepositry.ViewCategory();
			return View(CategoryList);
		}

		[HttpGet]
		public ActionResult Edit(Category category)
		{
			Category categoryDetail = categoryRepositry.FetchData(category.categoryId);
			return View(categoryDetail);
		}
		[HttpPost]
		public ActionResult Edit(CategoryModel categoryModel)
		{

			Category category = new Category();
			category.categoryName = categoryModel.categoryName;
			category.categoryId = categoryModel.categoryId;
			categoryRepositry.UpdateCategory(category);
			return RedirectToAction("Handle_Category");
		}

		public ActionResult Delete(int id)
		{
			categoryRepositry.DeleteCategory(id);
			return RedirectToAction("Handle_Category");
		}
	}
}