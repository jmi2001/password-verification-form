using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    class PasswordAdvisor
    {
        public static bool PasswordLengthValid(string password)
        {
            bool valid = false;

            if (password.Length >= 3 && password.Length <= 8)
                valid = true;

            return valid;
        }

        public static bool PasswordFirstLastCharacterValid(string password)
        {
            bool valid = false;

            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            // password length needs to be at least 2 characters before validating
            if (password.Length < 2)
            {
                return false;
            }

            string firstLetter = password.Substring(0, 1);
            string lastLetter = password.Substring(password.Length - 1, 1);

            if (Char.IsUpper(firstLetter[0]))
            {
                if (Char.IsLower(lastLetter[0]))
                {
                    valid = true;
                }
            }             

            return valid;
        }
              
        public static bool PasswordDigitValid(string password)
        {
            bool valid = false;

            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            // password length to be at least 1 character
            if (password.Length < 1)
            {
                return false;
            }

            for (int i = 1; i < password.Length - 1; i++)
            {
                char item = password[i];
                if (Char.IsDigit(item))
                {
                    valid = true;
                    break;
                }
            }

            return valid;
        }

        public static bool PasswordLettersNumbersValid(string password)
        { 
            bool valid = true;

            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            // password length needs to be at least 3 characters before validating
            if (password.Length < 3)
            {
                return false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                char item = password[i];
                if (!Char.IsLetter(item) && !Char.IsDigit(item))
                {
                    valid = false;
                }
            }
                   
            return valid;
        }
    }
}
