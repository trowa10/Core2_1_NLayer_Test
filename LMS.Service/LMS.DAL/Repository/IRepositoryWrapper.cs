using LMS.DALL.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.DALL.Repository
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }      
    }
}
