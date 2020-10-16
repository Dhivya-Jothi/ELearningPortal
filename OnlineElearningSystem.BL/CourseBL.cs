using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineElearningSystem.BL
{
	public class CourseBL
	{

		CourseRepositry courseRepositry = new CourseRepositry();
		CategoryRepositry categoryRepositry = new CategoryRepositry();
		TopicRepositry topicRepositry = new TopicRepositry();
		LinkRepositry linkRepositry = new LinkRepositry();

		public void AddCategory(Category category)
		{

			categoryRepositry.AddCategory(category);
		}
		
		public void AddCourse(Course course)
		{
			
			courseRepositry.AddCourse(course);
		}
		public IEnumerable<Category> GetCategory()
		{
			return courseRepositry.GetCategory();
		}

		public void AddTopic(Topic topic)
		{
			topicRepositry.AddTopic(topic);
		}
		public IEnumerable<Course> GetCourse()
		{
			return topicRepositry.GetCourse();
		}
		

		public void AddLink(Link link)
		{
			linkRepositry.AddLink(link);
		}
		public IEnumerable<Topic> GetTopic()
		{
			return linkRepositry.GetTopic();
		}
	}
}
