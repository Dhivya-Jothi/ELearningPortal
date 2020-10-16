using System.ComponentModel.DataAnnotations;


namespace OnlineElearningSystem.Entity
{
	public class Course
	{
		[key]
		[Required]
		public int courseId { get; set; }
		[Required]
		public string courseName { get; set; }
		public int categoryId { get; set; }
		public Category Category { get; set; }
	}
}
