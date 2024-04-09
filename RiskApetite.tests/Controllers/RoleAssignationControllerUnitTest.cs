using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using RiskAppetite.Models;
using RiskAppetite.Models.Dto;
using RiskAppetite.Services.RoleAssignation;
using System.Threading.Tasks;
using System.Collections.Generic;
using RiskAppetite.Controllers;
using UserProfile = RiskAppetite.Models.UserProfile;
using Cbe.DomainException;

namespace RiskAppetite.Tests.Services.RoleAssignation
{
    public class RoleAssignationTests
    {
        [Fact]
        public async Task RoleAssignment_NewUser_SuccessfullyAdded()
        {
            // Arrange
            var userRoleAssignationDto = new UserRoleAssignationDto
            {
                // Set the properties of the DTO
                UserRoleId = 2,
                EmployeeId = "123456",
                UserEmail = "test@example.com"
            };

            var userProfile = new UserProfile
            {
                // Set the properties of the UserProfile object
                Id = 1,
                UserEmail = "test@example.com",
                EmployeeId = "123456",
                UserRoleId = 2,
                Severities = new List<Severity>(),
                SeverityForAnalyses = new List<SeverityForAnalysis>(),
                UserRole = new Role()
            };
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(m => m.Map<UserProfile>(It.IsAny<UserRoleAssignationDto>()))
                .Returns(userProfile);


            var roleAssignationMock = new Mock<IRoleAssignation>();
            roleAssignationMock.Setup(r => r.RoleAssignment(It.IsAny<UserRoleAssignationDto>()))
                .ReturnsAsync(userRoleAssignationDto);

            //var controller = new RoleAssignations(roleAssignationMock.Object);
            var controller = new RoleAssignations(roleAssignationMock.Object, mapperMock.Object);

            // Act
            var result = await controller.RoleAssignment(userRoleAssignationDto);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Same(userRoleAssignationDto, okResult.Value);
        } 
        
        [Fact]
        public async Task RoleAssignment_UserAlreadyExists_ThrowsDataNotFoundException()
        {
            // Arrange
            var userRoleAssignationDto = new UserRoleAssignationDto
            {
                // Set the properties of the DTO
                UserRoleId = 2,
                EmployeeId = "123456",
                UserEmail = "test@example.com"
            };

            var existingUser = new UserProfile
            {
                // Set the properties of the existing user
                Id = 1,
                UserEmail = "test@example.com",
                EmployeeId = "123456",
                UserRoleId = 2,
                Severities = new List<Severity>(),
                SeverityForAnalyses = new List<SeverityForAnalysis>(),
                UserRole = new Role()
            };
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(m => m.Map<UserProfile>(It.IsAny<UserRoleAssignationDto>()))
                .Returns(existingUser);


            var roleAssignationMock = new Mock<IRoleAssignation>();
            roleAssignationMock.Setup(r => r.RoleAssignment(It.Is<UserRoleAssignationDto>(dto =>
                    dto.EmployeeId == existingUser.EmployeeId || dto.UserEmail == existingUser.UserEmail)))
                .ThrowsAsync(new DataNotFoundException("User already exists."));

            //var controller = new RoleAssignations(roleAssignationMock.Object);
            var controller = new RoleAssignations(roleAssignationMock.Object, mapperMock.Object);

            // Act
            await Assert.ThrowsAsync<DataNotFoundException>(() => controller.RoleAssignment(userRoleAssignationDto));

        }



    }
}