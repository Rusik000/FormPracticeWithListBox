using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public static class Verification
    {

        public static bool isDataContainsOnlyLetters(in string data)
        {
            return Regex.IsMatch(data, @"^[a-zA-Z ,-]+$") && (!string.IsNullOrWhiteSpace(data));
        }

        public static bool IsDataContainsOnlyIntegers(in string data)
        {
            return data.All(char.IsDigit) && (!string.IsNullOrWhiteSpace(data));
        }

        public static bool IsPhoneNumberCorrectFormat(in string data)
        {
            return (!string.IsNullOrWhiteSpace(data)) && Regex.IsMatch(data, "^[0-9 +()-]+$");
        }


    }
}
