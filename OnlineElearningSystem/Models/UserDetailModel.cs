
using System.ComponentModel.DataAnnotations;


namespace OnlineElearningSystem.Models
{
	public class UserDetailModel
	{ 
		public int userId { get; set; }
		[Required]
		[MaxLength(30)]
		[DataType(DataType.Text)]
		[RegularExpression("^[A-Z][a-zA-Z]*", ErrorMessage = "Enter valid name")]
		public string userName { get; set; }
		[Required]
		[MaxLength(20)]
		[RegularExpression("^[A-Z][a-zA-Z]*[!@#$%^&*][0-9]+$", ErrorMessage = "Enter valid password, example:MyTeddy@34")]
		public string password { get; set; }
		[Required]
		[MaxLength(20)]
		[Compare("password")]
		public string confirmPassword { get; set; }
		public string gender { get; set; }
		[DataType(DataType.PhoneNumber)]
		[Required]
		[RegularExpression("^[6-9][0-9]{9}$", ErrorMessage = "Enter valid mobile number")]
		public long mobileNumber { get; set; }
		[DataType(DataType.EmailAddress)]
		[Required]
		[RegularExpression("[a-z]+[0-9a-z]*@[a-z]*.[a-z]{3}", ErrorMessage = "Email is not valid.")]
		public string mailId { get; set; }
		public string dateOfBirth { get; set; }
		[Required]
		public string mediumOfStudy { get; set; }
		public string userRole { get; set; }

		//public UserDetailModel(string userId, string userName, string password, string confirmPassword, string mediumOfStudy, string mobileNumber, string mailId, string dateOfBirth)
		//{
		//	this.userId = userId;
		//	this.userName = userName;
		//	this.password = password;
		//	this.confirmPassword = confirmPassword;
		//	this.mediumOfStudy = mediumOfStudy;
		//	this.mobileNumber = mobileNumber;
		//	this.mailId = mailId;
		//	this.dateOfBirth = dateOfBirth;
		//}
	}	
}
