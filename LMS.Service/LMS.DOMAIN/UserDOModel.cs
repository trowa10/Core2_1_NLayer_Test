using System;

namespace LMS.DOMAIN
{
    public class UserDOModel
    {
        private int _id { get; set; }
        private string _fname { get; set; }
        private string _mname { get; set; }
        private string _lname { get; set; }

        public UserDOModel(int id, string fname, string mname, string lname)
        {
            _id = id;
            _fname = fname;
            _mname = mname;
            _lname = lname;
        }

        public int Id => _id;
        public string Firstname => _fname;
        public string MiddleName => _mname;
        public string LastName => _lname;
    }
}
