using OnlineElearningSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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
			SqlParameter userName = new SqlParameter("@userName", userDetail.userName);
			SqlParameter dateOfBirth = new SqlParameter("@dateOfBirth", userDetail.dateOfBirth);
			SqlParameter password = new SqlParameter("@Password", userDetail.confirmPassword);
			SqlParameter gender = new SqlParameter("@gender", userDetail.gender);
			SqlParameter mobileNumber = new SqlParameter("@mobileNumber", userDetail.mobileNumber);
			SqlParameter mediumOfStudy = new SqlParameter("@mediumOfStudy", userDetail.mediumOfStudy);
			SqlParameter mailId = new SqlParameter("@mailId", userDetail.mailId);
			SqlParameter role = new SqlParameter("@userRole", userDetail.userRole);
			using (UserDetailDB dB = new UserDetailDB())
			{

				int result = dB.Database.ExecuteSqlCommand("[dbo].[sp_InsertDetails] @userName, @Password, @gender, @mobileNumber, @mailId, @dateOfBirth, @mediumOfStudy, @userRole", userName, password, gender, mobileNumber, mailId, dateOfBirth, mediumOfStudy, role);
			}

			//userDetailDB.userDetails.Add(userDetail);
			//userDetailDB.SaveChanges();
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
		public UserDetail FetchData(int id)
		{			
			UserDetail userDetail = new UserDetail();
			userDetail = userDetailDB.userDetails.Where(model=>model.userId == id).SingleOrDefault();
			return userDetail;
		}
		public void UpdateUser(UserDetail userDetail)
		{
			SqlParameter id = new SqlParameter("@userId", userDetail.userId);
			SqlParameter userName = new SqlParameter("@userName", userDetail.userName);
			SqlParameter dateOfBirth = new SqlParameter("@dateOfBirth", userDetail.dateOfBirth);
			SqlParameter password = new SqlParameter("@Password", userDetail.confirmPassword);
			SqlParameter gender = new SqlParameter("@gender", userDetail.gender);
			SqlParameter mobileNumber = new SqlParameter("@mobileNumber", userDetail.mobileNumber);
			SqlParameter mediumOfStudy = new SqlParameter("@mediumOfStudy", userDetail.mediumOfStudy);
			SqlParameter mailId = new SqlParameter("@mailId", userDetail.mailId);
			SqlParameter role = new SqlParameter("@userRole", userDetail.userRole);
			using (UserDetailDB dB = new UserDetailDB())
			{
				using (var trans = userDetailDB.Database.BeginTransaction())
				{
					try
					{
						int result = dB.Database.ExecuteSqlCommand("[dbo].[sp_UpdateDetails]@userId,@userName, @Password, @gender, @mobileNumber, @mailId, @dateOfBirth, @mediumOfStudy, @userRole", id, userName, password, gender, mobileNumber, mailId, dateOfBirth, mediumOfStudy, role);
						trans.Commit();
					}
					catch(Exception exception)
					{
						trans.Rollback();
						Console.WriteLine(exception.InnerException);
					}
				}
					
			}
			//userDetailDB.Entry(userDetail).State = EntityState.Modified;
			//userDetailDB.SaveChanges();
		}
		public void DeleteUser(int id)
		{
			SqlParameter Id = new SqlParameter("@userId", id);
			var data = userDetailDB.Database.ExecuteSqlCommand("sp_DeleteDetails @userId", Id);
			//UserDetail details = userDetailDB.userDetails.Find(id);
			//userDetailDB.userDetails.Remove(details);
			userDetailDB.SaveChanges();
		}
	}	 
}