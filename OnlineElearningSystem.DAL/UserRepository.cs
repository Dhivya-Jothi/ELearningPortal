using OnlineElearningSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace OnlineElearningSystem.DAL
{
    public class UserRepository
    {
		public static List<UserDetail> UserList = new List<UserDetail>();
		UserDetailDB userDetailDB = new UserDetailDB();
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
			userDetailDB.userDetails.Add(userDetail);
			userDetailDB.SaveChanges();
		}
		public UserDetail LoginUser(UserDetail userDetail)
		{
			foreach(var DbContext in userDetailDB.userDetails)
			{
				if(DbContext.userName.Equals(userDetail.userName)&&(DbContext.confirmPassword.Equals(userDetail.confirmPassword)))
				{
					return DbContext;
				}			
			}
			return null;
		}
		public IEnumerable<UserDetail> ViewUser()
		{			
			List<UserDetail> userDetails = userDetailDB.userDetails.ToList();
			return userDetails;
		}
		public UserDetail FetchData(string id)
		{			
			UserDetail userDetail = new UserDetail();
			userDetail = userDetailDB.userDetails.Where(model=>model.userId == id).SingleOrDefault();
			return userDetail;
		}
		public void UpdateUser(UserDetail userDetail)
		{			
			userDetailDB.Entry(userDetail).State = EntityState.Modified;
			userDetailDB.SaveChanges();
		}
		public void DeleteUser(UserDetail userDetail)
		{		
			userDetailDB.userDetails.Attach(userDetail);
			userDetailDB.userDetails.Remove(userDetail);
			userDetailDB.SaveChanges();
		}
	}	 
}