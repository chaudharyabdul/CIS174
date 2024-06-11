using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FirstResponsiveWebAppChaudhary.Models;
using Xunit;

namespace FirstResponsiveWebAppChaudhary.UnitTests
{
    public class UserTests
    {
        [Fact]
        public void User_Name_IsRequired()
        {
            // Arrange
            var user = new User { Name = null, BirthYear = 2000, BirthDate = DateTime.Now };

            // Act
            var context = new ValidationContext(user, null, null);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(user, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, v => v.ErrorMessage == "Please enter your name.");
        }

        [Fact]
        public void User_BirthYear_IsRequired_And_RangeValid()
        {
            // Arrange
            var user = new User { Name = "John", BirthYear = 1899, BirthDate = DateTime.Now };

            // Act
            var context = new ValidationContext(user, null, null);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(user, context, results, true);

            // Assert
            Assert.False(isValid);
            Assert.Contains(results, v => v.ErrorMessage == "Invalid birth year.");
        }

        [Fact]
        public void AgeThisYear_Returns_Correct_Age()
        {
            // Arrange
            var user = new User { BirthYear = 2000 };

            // Act
            var age = user.AgeThisYear(2024);

            // Assert
            Assert.Equal(24, age);
        }

        [Fact]
        public void AgeToday_Returns_Correct_Age()
        {
            // Arrange
            var user = new User { BirthDate = new DateTime(2000, 6, 10) };

            // Act
            var age = user.AgeToday();

            // Assert
            Assert.Equal(24, age);
        }
    }
}
