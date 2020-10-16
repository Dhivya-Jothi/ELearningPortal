using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineElearningSystem.Entity
{
	public class Link
	{

		[key]
		[Required]
		public int linkId { get; set; }
		[Required]
		public string link{ get; set; }
		public int topicId { get; set; }
		public Topic Topic { get; set; }
	}
}
