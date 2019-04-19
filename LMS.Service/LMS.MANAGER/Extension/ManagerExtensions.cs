using LMS.DOMAIN;
using LMS.MANAGER.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS.MANAGER.Extension
{
    public static class ManagerExtensions
    {
        public static UserModel Map(this User user)
        {
            return new UserModel(user);
        }

        public static IEnumerable<UserModel> Map(this IEnumerable<User> users)
        {
            return users.Select(x=>x.Map());
        }


    }
}
