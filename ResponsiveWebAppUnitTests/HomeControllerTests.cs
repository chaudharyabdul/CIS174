using FirstResponsiveWebAppChaudhary.Controllers;
using FirstResponsiveWebAppChaudhary.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace FirstResponsiveWebAppChaudhary.UnitTests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Null(viewResult.Model);
        }

        [Fact]
        public void Index_Post_Returns_ViewResult_With_ValidModel()
        {
            // Arrange
            var controller = new HomeController();
            var user = new User { Name = "John", BirthYear = 2000, BirthDate = new DateTime(2000, 6, 10) };

            // Act
            var result = controller.Index(user);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(user, viewResult.Model);
            Assert.Equal($"Hello, {user.Name}! On December 31st, 2024, you will be {user.AgeThisYear(2024)} years old.", controller.ViewBag.Message);
            Assert.Equal($"Today, you are {user.AgeToday()} years old.", controller.ViewBag.ExtraMessage);
        }

        [Fact]
        public void Index_Post_Returns_ViewResult_With_InvalidModel()
        {
            // Arrange
            var controller = new HomeController();
            controller.ModelState.AddModelError("Name", "Required");
            var user = new User { BirthYear = 2000, BirthDate = new DateTime(2000, 6, 10) };

            // Act
            var result = controller.Index(user);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(user, viewResult.Model);
            Assert.Null(controller.ViewBag.Message);
            Assert.Null(controller.ViewBag.ExtraMessage);
        }
    }
}
