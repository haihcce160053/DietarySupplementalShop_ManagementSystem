using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Account
    {
        private string username;
        private string password;
        private string securityAnswer;
        private string fullname;
        private string phoneNumber;
        private string gender;
        private string email;
        private string accountTypeID;

        public Account()
        {

        }

        public Account(string username, string password, string securityAnswer, string fullname, string phoneNumber, string gender, string email, string accountTypeID)
        {
            this.Username = username;
            this.Password = password;
            this.SecurityAnswer = securityAnswer;
            this.Fullname = fullname;
            this.PhoneNumber = phoneNumber;
            this.Gender = gender;
            this.Email = email;
            this.AccountTypeID = accountTypeID;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string SecurityAnswer { get => securityAnswer; set => securityAnswer = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string AccountTypeID { get => accountTypeID; set => accountTypeID = value; }
    }
}
