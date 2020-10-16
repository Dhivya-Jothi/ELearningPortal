using OnlineElearningSystem.BL;
using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using OnlineElearningSystem.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineElearningSystem.Controllers
{
    public class LinkController : Controller
    {
		// GET: Link
		CourseBL course = new CourseBL();
		LinkRepositry linkRepositry = new LinkRepositry();
		public ActionResult Index()
        {
            return View();
        }
		[HttpGet]
		public ActionResult CreateLink()
		{
			ViewBag.Topic = new SelectList(course.GetTopic(), "topicId", "topicName");
			return View();
		}
		[HttpPost]
		public ActionResult CreateLink(LinkModel linkModel)
		{
			ViewBag.Topic = new SelectList(course.GetTopic(), "topicId", "topicName");
			if (ModelState.IsValid)
			{

				var newUser = AutoMapper.Mapper.Map<LinkModel,Link>(linkModel);
				CourseBL course = new CourseBL();
				course.AddLink(newUser);
			}
			return View();
		}
		IEnumerable<Link> LinkList;
		public ActionResult Handle_Link()
		{
			LinkList = linkRepositry.ViewLink();
			return View(LinkList);
		}

		[HttpGet]
		public ActionResult Edit(Link link)
		{
		
			ViewBag.Topic = new SelectList(course.GetTopic(), "topicId", "topicName");
			Link linkDetail = linkRepositry.FetchData(link.linkId);
			return View(linkDetail);
		}
		[HttpPost]
		public ActionResult Edit(LinkModel linkModel)
		{

			Link link = new Link();
			link.link = linkModel.link;
			link.linkId = linkModel.linkId;
			link.topicId = linkModel.topicId;
			linkRepositry.UpdateLink(link);
			return RedirectToAction("Handle_Link");
		}

		public ActionResult Delete(int id)
		{
			linkRepositry.DeleteLink(id);
			return RedirectToAction("Handle_Link");
		}
	}
}