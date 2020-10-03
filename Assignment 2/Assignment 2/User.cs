using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class User
    {
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string dob;
        private string userType;

        public User(string username, string password, string firstName, string lastName, string dob, string userType)
        {
            this.Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Dob = dob;
            this.UserType = userType;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Dob { get => dob; set => dob = value; }
        public string UserType { get => userType; set => userType = value; }


    }
}
