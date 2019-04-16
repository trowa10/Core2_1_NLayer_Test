using LMS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LMS.SERVICE
{
    public interface IUserService
    {
        Task<ICollection<User>> GetUser();
    }
}
