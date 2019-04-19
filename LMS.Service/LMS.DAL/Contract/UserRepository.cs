using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LMS.DALL.Data;
using LMS.DALL.Repository;
using LMS.DOMAIN;

namespace LMS.DALL.Contract
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private LMSContext _lMSContext;
        public UserRepository(LMSContext lMSContext) : base(lMSContext)
        {
            this._lMSContext = lMSContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return FindAll()
                .OrderBy(x => x.LastName);
        }

        public User GetUserById(int userId)
        {
            return FindByCondition(x => x.UserId == userId)
                .DefaultIfEmpty(new User())
                .FirstOrDefault();
        }
    }
}
