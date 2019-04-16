using LMS.DALL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using LMS.DOMAIN;

namespace LMS.DALL.Contract
{
    public interface IUserRepository: IRepositoryBase<User>
    {
        IEnumerable<User> GetUser();
    }
}
