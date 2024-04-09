using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using RiskAppetite.Models.Dto;
using RiskAppetite.Models;
using Xunit;
using NuGet.Protocol;
using Azure;

namespace RiskApetite.tests.Controllers
{
    public class AuthControllerTests
    {

        [Fact]
        public async Task Login_ValidCredentials_ReturnsOkResultWithToken()
        {
            // Arrange
            var model = new UserLoginRequestDto
            {
                UserName = "addisgashaw",
                Password = "Ethiopia@999"
            };

            // Mock the database context
            var mockContext = new Mock<RiskApetiteContext>();

            // Mock the user profile data
            var userProfile = new UserProfile
            {
                EmployeeId = "050036",
                UserEmail = "addisgashaw@cbe.comy.et",
                UserRoleId = 1,
                Id = 17
            };
            var userProfiles = new List<UserProfile> { userProfile };

            // Set up the mock behavior for the database context
            var mockDbSet = new Mock<DbSet<UserProfile>>();
            mockDbSet.As<IQueryable<UserProfile>>().Setup(m => m.Provider).Returns(userProfiles.AsQueryable().Provider);
            mockDbSet.As<IQueryable<UserProfile>>().Setup(m => m.Expression).Returns(userProfiles.AsQueryable().Expression);
            mockDbSet.As<IQueryable<UserProfile>>().Setup(m => m.ElementType).Returns(userProfiles.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<UserProfile>>().Setup(m => m.GetEnumerator()).Returns(userProfiles.AsQueryable().GetEnumerator());

            mockContext.Setup(c => c.UserProfiles).Returns(mockDbSet.Object);

            var mockMapper = new Mock<IMapper>();

            var controller = new AuthController(mockContext.Object, mockMapper.Object);
            // Act
            var result = controller.Login(model);
            OkObjectResult okResult = Assert.IsType<OkObjectResult>(result);
            //Optional: additional assertions for this test case
            var value = okResult.Value;
             //Assert
            Assert.NotNull(value);
            Console.WriteLine(value);
            Assert.Equal(200, okResult.StatusCode);
        }
    }
}