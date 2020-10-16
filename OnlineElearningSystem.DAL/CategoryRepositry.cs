using OnlineElearningSystem.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace OnlineElearningSystem.DAL
{
	public class CategoryRepositry
	{
		//public static List<Category> categoryList = new List<Category>();
		UserDetailDB userDetailDB = new UserDetailDB();
		public void AddCategory(Category category)
		{
			userDetailDB.categories.Add(category);
			userDetailDB.SaveChanges();
		}

		public IEnumerable<Category> ViewCategory()
		{
			List<Category> category = userDetailDB.categories.ToList();
			return category;
		}
		public Category FetchData(int id)
		{
			Category category = new Category();
			category = userDetailDB.categories.Where(model => model.categoryId == id).SingleOrDefault();
			return category;
		}
		public void UpdateCategory(Category category)
		{
			userDetailDB.Entry(category).State = EntityState.Modified;
			userDetailDB.SaveChanges();			
		}
		public void DeleteCategory(int id)
		{
			Category details = userDetailDB.categories.Find(id);
			userDetailDB.categories.Remove(details);
			userDetailDB.SaveChanges();
		}
	}
}
