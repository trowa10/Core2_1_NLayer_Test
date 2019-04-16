using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LMS.DOMAIN;
using LMS.MANAGER;

namespace LMS.SERVICE
{
    public class UserService: IUserService
    {
        private IUserManager _userManager;
        public UserService(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public async Task<ICollection<User>> GetUser()
        {           
            return await _userManager.GetUser();
        }
    }
}
