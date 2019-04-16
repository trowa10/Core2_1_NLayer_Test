using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LMS.DALL;
using LMS.DOMAIN;

namespace LMS.MANAGER
{
    public class UserManager : IUserManager
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public UserManager() { }

        public async Task<ICollection<User>> GetUser()
        {
            return await _userDal.Get();
        }
    }
}
