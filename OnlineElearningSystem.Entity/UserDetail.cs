
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineElearningSystem.Entity
{
	public class UserDetail
	{
		[Key]
		[Required]
		public string userId { get; set; }
		[Required]
		public string userName { get; set; }
		[Required]
		[Column("Password")]
		public string confirmPassword { get; set; }
		[Required]
		public string gender { get; set; }	
		[Required]	
		public string mobileNumber { get; set; }	
		[Required]	
		public string mailId { get; set; }
		public string dateOfBirth { get; set; }
		[Required]
		public string mediumOfStudy { get; set; }
		[Required]
		public string userRole { get; set; }	
	}

}
