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

        public async Task<ICollection<UserDOModel>> Get()
        {
            var users = new List<UserDOModel>()
            {
               new UserDOModel(1,"Marlon", "Francisco", "Elpedes"),
                new UserDOModel(1,"John", "Clark", "Elpedes")
            };


            return await Task.Run(()=>users);
        }
    }
}
