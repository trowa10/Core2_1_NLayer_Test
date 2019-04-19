using LMS.DOMAIN;
using LMS.MANAGER.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LMS.MANAGER
{
    public interface IUserManager
    {
        IEnumerable<UserModel> GetUsers();
        UserModel GetUserById(int userId);
    }
}
