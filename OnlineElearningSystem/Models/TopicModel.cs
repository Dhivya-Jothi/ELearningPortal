using OnlineElearningSystem.Entity;

using System.ComponentModel.DataAnnotations;


namespace OnlineElearningSystem.Models
{
	public class TopicModel
	{
		public int topicId { get; set; }
		[Required]
		[MaxLength(100)]
		[RegularExpression("^[A-Z][a-zA-Z]*", ErrorMessage = "Enter valid Topic name")]
		public string topicName { get; set; }
		[Required]
		public int cost { get; set; }
		public int courseId { get; set; }
		public Course Course { get; set; }
	}
}