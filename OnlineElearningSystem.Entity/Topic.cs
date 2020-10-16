using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineElearningSystem.Entity
{
	public class Topic
	{
		[key]
		[Required]
		public int topicId { get; set; }
		[Required]
		public string topicName { get; set; }
		[Required]
		public int cost { get; set; }
		public int courseId { get; set; }
		public Course Course{ get; set; }
	}
}
