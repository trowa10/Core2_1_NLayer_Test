using LMS.DOMAIN;
using System;
using System.Collections.Generic;
using System.Text;

namespace LMS.MANAGER.Model
{
    public class UserModel
    {
        private readonly long _userId;
        private readonly string _firstName;
        private readonly string _lastName;
       // private readonly string _gender;
        private readonly DateTime _dateOfBirth;
        private readonly string _phoneNumber;
        private readonly string _email;

        public UserModel(User user)
        {
            this._userId = user.UserId;
            this._firstName = user.FirstName;
            this._lastName = user.LastName;
           // this._gender = user.Gender;
            this._dateOfBirth = user.DateOfBirth;
            this._phoneNumber = user.PhoneNumber;
            this._email = user.Email;
        }

        public long UserId => _userId;
        public string Name => $"{_firstName} {LastName}";
        public string FirstName => _firstName;
        public string LastName => _lastName;
        //public string Gender => _gender;
        public DateTime DateOfBirth => _dateOfBirth;
        public string PhoneNumber => _phoneNumber;
        public string Email => _email;
    }
}
