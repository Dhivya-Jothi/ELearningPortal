using OnlineElearningSystem.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace OnlineElearningSystem.DAL
{
	public class LinkRepositry
	{
		UserDetailDB userDetailDB = new UserDetailDB();
		public void AddLink(Link link)
		{
			userDetailDB.Links.Add(link);
			userDetailDB.SaveChanges();
		}
		public IEnumerable<Topic> GetTopic()
		{
			return userDetailDB.Topics.ToList();
		}
		public IEnumerable<Link> ViewLink()
		{
			List<Link> link = userDetailDB.Links.ToList();
			return link;
		}
		public Link FetchData(int id)
		{
			Link link = new Link();
			link = userDetailDB.Links.Where(model => model.linkId == id).SingleOrDefault();
			return link;
		}
		public void UpdateLink(Link link)
		{
			userDetailDB.Entry(link).State = EntityState.Modified;
			userDetailDB.SaveChanges();
		}
		public void DeleteLink(int id)
		{
			Link details = userDetailDB.Links.Find(id);
			userDetailDB.Links.Remove(details);
			userDetailDB.SaveChanges();
		}
	}
}
