using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineElearningSystem.Models
{
	public class LoginModel
	{
		[Required]
		[MaxLength(30)]
		[DataType(DataType.Text)]
		[RegularExpression("^[A-Z][a-zA-Z]*", ErrorMessage = "Enter valid name")]
		public string userName { get; set; }
		[Required]
		[MaxLength(20)]
		[RegularExpression("^[A-Z][a-zA-Z]*[!@#$%^&*][0-9]+$", ErrorMessage = "Enter valid password, example:MyTeddy@34")]
		public string password { get; set; }
	}
}