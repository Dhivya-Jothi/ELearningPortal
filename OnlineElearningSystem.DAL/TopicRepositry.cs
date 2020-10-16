using OnlineElearningSystem.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OnlineElearningSystem.DAL
{
	public class TopicRepositry
	{
		UserDetailDB userDetailDB = new UserDetailDB();
		public void AddTopic(Topic topic)
		{
			userDetailDB.Topics.Add(topic);
			userDetailDB.SaveChanges();
		}
		public IEnumerable<Course> GetCourse()
		{
			 return userDetailDB.Courses.ToList();
		}
		public IEnumerable<Topic> ViewTopic()
		{
			List<Topic> topic = userDetailDB.Topics.ToList();
			return topic;
		}

		public Topic FetchData(int id)
		{
			Topic topic = new Topic();
			topic = userDetailDB.Topics.Where(model => model.topicId == id).SingleOrDefault();
			return topic;
		}
		public void UpdateTopic(Topic topic)
		{
			userDetailDB.Entry(topic).State = EntityState.Modified;
			userDetailDB.SaveChanges();
		}
		public void DeleteTopic(int id)
		{
			Topic details = userDetailDB.Topics.Find(id);
			userDetailDB.Topics.Remove(details);
			userDetailDB.SaveChanges();
		}
	}
}
