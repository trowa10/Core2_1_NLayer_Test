using LMS.DALL.Contract;
using LMS.DALL.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.DALL.Repository
{
    public class RepositoryWrapper:IRepositoryWrapper
    {
        private readonly LMSContext _repoContext;
        private IUserRepository _user;
    
        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }

                return _user;
            }
        }
    }
}
