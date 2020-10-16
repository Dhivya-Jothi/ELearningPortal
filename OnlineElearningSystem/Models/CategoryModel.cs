

using System.ComponentModel.DataAnnotations;

namespace OnlineElearningSystem.Models
{
	public class CategoryModel
	{
		public int categoryId { get; set; }
		[Required]
		[MaxLength(50)]
		[RegularExpression("^[A-Z][a-zA-Z]*", ErrorMessage = "Enter valid Category name")]
		public string categoryName { get; set; }

	}
}