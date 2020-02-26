using OnlineElearningSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineElearningSystem.DAL
{
    public class UserRespositry
    {
		public static List<UserDetail> UserList = new List<UserDetail>();
		//static UserRespositry()
		//{

		//}
		public static List<UserDetail>SignUp()
		{
			UserDetailDB userDetailDB = new UserDetailDB();
			return userDetailDB.userDetails.ToList();
		}
		//public static IEnumerable<UserDetail> GetUserDetails()
		//{
		//	return UserList;
		//}
		public void AddUser(UserDetail userDetail)
		{

			UserDetailDB userDetailDB = new UserDetailDB();
			userDetailDB.userDetails.Add(userDetail);
			userDetailDB.SaveChanges();
		}

		
	}
}