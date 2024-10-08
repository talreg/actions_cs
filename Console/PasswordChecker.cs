using System;

namespace PasswordCheckerApp
{
    public class PasswordChecker
    {
        public bool IsPasswordStrong(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperCase = true;
                else if (char.IsLower(c)) hasLowerCase = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else hasSpecialChar = true;
            }

            return hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar && password.Length >= 8;
        }
    }

    public static class PasswordCheckerFactory
    {
        public static PasswordChecker Create()
        {
            return new PasswordChecker();
        }
    }
}