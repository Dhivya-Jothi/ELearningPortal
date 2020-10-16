using OnlineElearningSystem.Entity;

using System.ComponentModel.DataAnnotations;


namespace OnlineElearningSystem.Models
{
	public class LinkModel
	{
		public int linkId { get; set; }
		[Required]
		[MaxLength(100)]
		[RegularExpression("^[A-Z][a-zA-Z]*", ErrorMessage = "Enter valid Link ")]
		public string link { get; set; }
		public int topicId { get; set; }
		public Topic Topic { get; set; }
	}
}