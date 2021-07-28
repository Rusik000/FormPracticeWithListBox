using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Person
    {
        private string _name;
        private string _surname;
        private string _email;
        private string _phone;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = Verification.isDataContainsOnlyLetters(value)
                    ? value
                    : throw new Exception("Name is not consist of letters");

            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = Verification.isDataContainsOnlyLetters(value)
                    ? value
                    : throw new Exception("Surname is not consist of letters");

            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = Verification.IsPhoneNumberCorrectFormat(value)
                    ? value
                    : throw new Exception("Phone is not correct format");
            }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public DateTime Birthdate { get; set; }

    }
}
