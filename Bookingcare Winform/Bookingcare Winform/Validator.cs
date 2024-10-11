using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bookingcare_Winform
{
    internal class Validator
    {
        public bool isValidEmail(string email)
        {
            // if length of text is null, return false
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            // regular expresstion string to valid email input
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // use regex to check valid email
            return Regex.IsMatch(email, emailPattern);
        }

        public bool isValidPhoneNumber(string phoneNumber)
        {
            // if length of text is null, return false
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                return false;
            }

            // regular expression string to check valid phonenumber input (just include number, length from 10 to 11)
            string phonePattern = @"^0\d{8,10}$";

            // use regex to check valid phonenumber
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}
