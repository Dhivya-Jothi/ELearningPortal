using OnlineElearningSystem.Entity;

using System.ComponentModel.DataAnnotations;


namespace OnlineElearningSystem.Models
{
	public class CourseModel
	{
		public int courseId { get; set; }
		[Required]
		[MaxLength(50)]
		[RegularExpression("^[A-Z][a-zA-Z]*", ErrorMessage = "Enter valid course name")]
		public string courseName { get; set; }
		public int categoryId { get; set; }
		public Category Category { get; set; }
	}
}