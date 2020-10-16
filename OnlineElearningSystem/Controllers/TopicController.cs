using OnlineElearningSystem.BL;
using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using OnlineElearningSystem.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineElearningSystem.Controllers
{
    public class TopicController : Controller
    {
		CourseBL course = new CourseBL();
		TopicRepositry topicRepositry = new TopicRepositry();
		// GET: Topic
		public ActionResult Index()
        {
            return View();
        }

		[HttpGet]
		public ActionResult Createtopic()
		{
			ViewBag.Course = new SelectList(course.GetCourse(), "courseId", "courseName");
			return View();
		}
		[HttpPost]
		public ActionResult Createtopic(TopicModel topicModel)
		{
			ViewBag.Course = new SelectList(course.GetCourse(), "courseId", "courseName");
			if (ModelState.IsValid)
			{

				var newUser = AutoMapper.Mapper.Map<TopicModel,Topic> (topicModel);
				CourseBL course = new CourseBL();
				course.AddTopic(newUser);
			}
			return View();
		}
		IEnumerable<Topic> TopicList;
		public ActionResult Handle_Topic()
		{
			TopicList = topicRepositry.ViewTopic();
			return View(TopicList);
		}

		[HttpGet]
		public ActionResult Edit(Topic topic)
		{
			ViewBag.Course = new SelectList(course.GetCourse(), "courseId", "courseName");
			Topic topicDetail = topicRepositry.FetchData(topic.topicId);
			return View(topicDetail);
		}
		[HttpPost]
		public ActionResult Edit(TopicModel topicModel)
		{

			Topic topic = new Topic();
			topic.topicName = topicModel.topicName;
			topic.topicId = topicModel.topicId;
			topic.courseId = topicModel.courseId;
			topic.cost = topicModel.cost;
			topicRepositry.UpdateTopic(topic);
			return RedirectToAction("Handle_Topic");
		}

		public ActionResult Delete(int id)
		{
			topicRepositry.DeleteTopic(id);
			return RedirectToAction("Handle_Topic");
		}
	}
}