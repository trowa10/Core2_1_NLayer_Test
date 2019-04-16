using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LMS.DOMAIN;

namespace LMS.DALL
{
    public class UserDal : IUserDal
    {
        public UserDal()
        {

        }

        public async Task<ICollection<User>> Get()
        {
            var users = new List<User>()
            {
               new User(){FirstName = "" },

            };


            return await Task.Run(() => users);
        }
    }
}
