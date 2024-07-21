using Microsoft.AspNetCore.Mvc;
using Olympics.Controllers;
using Olympics.Data;
using Olympics.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Olympics.Tests
{
    public class TicketControllerTests
    {
        private ApplicationDbContext _context;
        private TicketController _controller;

        public TicketControllerTests()
        {
            _context = TestDbContext.GetTestDbContext();
            _controller = new TicketController(_context);
        }

        private void ResetDatabase()
        {
            TestDbContext.ResetTestDbContext(_context);
        }

        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfTickets()
        {
            // Arrange
            ResetDatabase();
            _context.Tickets.AddRange(new List<Ticket>
            {
                new Ticket { Name = "Ticket1", Description = "Description1", SprintNumber = 1, PointValue = 5, Status = "to do" },
                new Ticket { Name = "Ticket2", Description = "Description2", SprintNumber = 2, PointValue = 8, Status = "in progress" }
            });
            _context.SaveChanges();

            // Act
            var result = await _controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Ticket>>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }

        [Fact]
        public void Create_ReturnsAViewResult()
        {
            // Arrange
            ResetDatabase();

            // Act
            var result = _controller.Create();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Create_Post_ReturnsARedirectAndAddsTicket_WhenModelStateIsValid()
        {
            // Arrange
            ResetDatabase();
            var ticket = new Ticket { Name = "Ticket1", Description = "Description1", SprintNumber = 1, PointValue = 5, Status = "to do" };

            // Act
            var result = await _controller.Create(ticket);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
            Assert.Single(_context.Tickets);
        }

        [Fact]
        public async Task Create_Post_ReturnsViewResultWithModel_WhenModelStateIsInvalid()
        {
            // Arrange
            ResetDatabase();
            _controller.ModelState.AddModelError("Name", "Required");
            var ticket = new Ticket { Description = "Description1", SprintNumber = 1, PointValue = 5, Status = "to do" };

            // Act
            var result = await _controller.Create(ticket);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<Ticket>(viewResult.ViewData.Model);
            Assert.Equal(ticket, model);
        }
    }
}