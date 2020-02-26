
using System.ComponentModel.DataAnnotations;

namespace OnlineElearningSystem.Entity
{
	public class UserDetail
	{
		[Key]
		[Required]
		public string userId { get; set; }
		[Required]
		[MaxLength(30)]
		[DataType(DataType.Text)]
		[RegularExpression(@"^[a-zA-Z]+(([',.-][a-zA-Z])?[a-zA-Z]*)*$", ErrorMessage = "Enter valid name")]
		public string userName { get; set; }
		[Required]
		[MaxLength(20)]
		//[RegularExpression(@"((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})", ErrorMessage ="Enter valid password, example:MyTeddy@34")]
		public string password { get; set; }
		[Required]
		[MaxLength(20)]
		[Compare("password")]
		public string confirmPassword { get; set; }
		public Sex gender { get; set; }
		[DataType(DataType.PhoneNumber)]
		[Required]
		//[RegularExpression(@"(0 / 91)?[7 - 9][0 - 9]{9}", ErrorMessage = "Enter valid mobile number")]
		public string mobileNumber { get; set; }
		[DataType(DataType.EmailAddress)]
		[Required]
		[RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
		public string mailId { get; set; }
		public string dateOfBirth { get; set; }
		[Required]
		public string mediumOfStudy { get; set; }
		[Required]
		public Role userRole { get; set; }
		
		public UserDetail(string userId, string userName, string password, string confirmPassword, string mediumOfStudy, string mobileNumber, string mailId, string dateOfBirth)
		{
			this.userId = userId;
			this.userName = userName;
			this.password = password;
			this.confirmPassword = confirmPassword;
			this.mediumOfStudy = mediumOfStudy;
			this.mobileNumber = mobileNumber;
			this.mailId = mailId;
			this.dateOfBirth = dateOfBirth;

		}

		public UserDetail()
		{
		}
	}
	public enum Role
	{
		User,
		Admin
	};
	public enum Sex
	{
		Male,
		Female,
		Others
	}
	
}
