using System;
using NUnit.Framework;

namespace UTSprint.Tests
{
    public class LoginPageTests
    {
        [Test]
        public void ShouldReturnFailureMessage()
        {
            //Arrange
            var loginpage = new LoginPage();
            var expectedusername = "123";
            var expectedpassword = "ABC456";

            //Act
            var result = loginpage.UserRegistration(expectedusername, expectedpassword);

            //Assert
            Assert.AreEqual("User Registration has failed", result);
        }

        [Test]

        public void ShouldReturnSucessMessage()
            {

            //Arrange

            var loginpage = new LoginPage();
            var expectedusername = "Mohua";
            var expectedpassword = "ABC456";

            //Act

            var result = loginpage.UserRegistration(expectedusername,expectedpassword);

            //Assert

            Assert.AreEqual("Registration is successful",result);

        }

        [Test]
        public void ShouldReturnFailureMessageWhenUserNameIsNull()
        {
            //Arrange
            var loginpage = new LoginPage();
            var expectedpassword = "ABC456";

            //Act
            var result = loginpage.UserRegistration(null, expectedpassword);

            //Assert
            Assert.AreEqual("User Registration has failed", result);
        }
    }
}
