using LMS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LMS.MANAGER
{
    public interface IUserManager
    {
        Task<ICollection<User>> GetUser();
    }
}
