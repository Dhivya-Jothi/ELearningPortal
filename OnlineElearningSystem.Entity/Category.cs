using System;
using System.ComponentModel.DataAnnotations;


namespace OnlineElearningSystem.Entity
{
	public class Category
	{
		[key]
		[Required]
		public int categoryId { get; set; }
		[Required]
		public string categoryName { get; set; }
	}
}
