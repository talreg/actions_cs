using System;
using Xunit;
using PasswordCheckerApp;

namespace PasswordCheckerTests
{
    public class PasswordCheckerTest
    {
        private readonly PasswordChecker _passwordChecker;

        public PasswordCheckerTest()
        {
            _passwordChecker = PasswordCheckerFactory.Create();
        }

        [Theory]
        [InlineData("Password123!", true)]
        [InlineData("password123!", false)]
        [InlineData("PASSWORD123!", false)]
        [InlineData("Password!", false)]
        [InlineData("Password123", false)]
        [InlineData("Pass123!", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsPasswordStrong_ShouldReturnExpectedResult(string password, bool expected)
        {
            bool result = _passwordChecker.IsPasswordStrong(password);
            Assert.Equal(expected, result);
        }
    }
}