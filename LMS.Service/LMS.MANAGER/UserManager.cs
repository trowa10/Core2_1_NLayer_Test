using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMS.DALL;
using LMS.DALL.Repository;
using LMS.DOMAIN;
using LMS.MANAGER.Extension;
using LMS.MANAGER.Model;

namespace LMS.MANAGER
{
    public class UserManager : IUserManager
    {
        private IRepositoryWrapper _repoWrapper;
        public UserManager(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        public UserModel GetUserById(int userId)
        {
            return _repoWrapper.User.GetUserById(userId).Map();
        }

        public IEnumerable<UserModel> GetUsers()
        {
            return _repoWrapper.User.GetUsers().Map();
        }
    }
}
