using OnlineElearningSystem.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace OnlineElearningSystem.DAL
{
	public class CourseRepositry
	{

		
		UserDetailDB userDetailDB = new UserDetailDB();
		
		public void AddCourse(Course course)
		{
			userDetailDB.Courses.Add(course);
			userDetailDB.SaveChanges();

		}
		public IEnumerable<Category> GetCategory()
		{
			return userDetailDB.categories.ToList();
		}
		public IEnumerable<Course> ViewCourse()
		{
			List<Course> course = userDetailDB.Courses.ToList();
			return course;
		}
		public Course FetchData(int id)
		{
			Course course = new Course();
			course = userDetailDB.Courses.Where(model => model.courseId == id).SingleOrDefault();
			return course;
		}
		public void UpdateCourse(Course course)
		{
			userDetailDB.Entry(course).State = EntityState.Modified;
			userDetailDB.SaveChanges();
		}
		public void DeleteCourse(int id)
		{
			Course details = userDetailDB.Courses.Find(id);
			userDetailDB.Courses.Remove(details);
			userDetailDB.SaveChanges();
		}
	}
}
