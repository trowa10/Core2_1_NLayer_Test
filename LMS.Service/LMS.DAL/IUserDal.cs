using LMS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LMS.DALL
{
    public interface IUserDal
    {
       Task<ICollection<UserDOModel>> Get();
    }
}
