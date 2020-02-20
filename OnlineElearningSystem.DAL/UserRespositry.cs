using OnlineElearningSystem.Entity;
using System;
using System.Collections.Generic;

namespace OnlineElearningSystem.DAL
{
    public class UserRespositry
    {
		public static List<UserDetail> UserList = new List<UserDetail>();
		static UserRespositry()
		{

		}
		public static IEnumerable<UserDetail> GetUserDetails()
		{
			return UserList;
		}
		public void AddUser(UserDetail userDetail)
		{
			UserList.Add(userDetail);
		}
	}
}
