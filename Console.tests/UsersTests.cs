using System;
using Xunit;

namespace ConsoleApp.Tests
{
    public class UserTest
    {
        [Fact]
        public void UserConstructor_ShouldInitializeProperties()
        {
            // Arrange
            var firstName = "John";
            var lastName = "Doe";
            var email = "john.doe@example.com";
            var password = "password123";

            // Act
            var user = new User(firstName, lastName, email, password);

            // Assert
            Assert.Equal(firstName, user.FirstName);
            Assert.Equal(lastName, user.LastName);
            Assert.Equal(email, user.Email);
            Assert.Equal(password, user.Password);
        }

        [Fact]
        public void DisplayUserInfo_ShouldOutputCorrectInfo()
        {
            // Arrange
            var firstName = "Jane";
            var lastName = "Doe";
            var email = "jane.doe@example.com";
            var password = "password456";
            var user = new User(firstName, lastName, email, password);
            var expectedOutput = $"First Name: {firstName}\nLast Name: {lastName}\nEmail: {email}\nPassword: {password}\n";

            // Act
            using (var sw = new System.IO.StringWriter())
            {
                System.Console.SetOut(sw);
                user.DisplayUserInfo();

                // Assert
                var result = sw.ToString();
                Assert.Equal(expectedOutput, result);
            }
        }
    }
}