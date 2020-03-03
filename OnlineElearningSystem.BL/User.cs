using OnlineElearningSystem.DAL;
using OnlineElearningSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineElearningSystem.BL
{
    public class User
    {
		UserRepository userRepository = new UserRepository();
		public void SignUp(UserDetail userDetail)
		{
			userRepository.AddUser(userDetail);
		}
		public UserDetail Login(UserDetail userDetail)
		{			
			return userRepository.LoginUser(userDetail);
		}
    }
}
