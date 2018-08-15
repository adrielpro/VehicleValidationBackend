using System;
using VehicleValidationBackend.Classes;
using VehicleValidationBackend.Classes.Enums;
using VehicleValidationBackend.Controllers;
using VehicleValidationBackend.Models;
using Xunit;

namespace web_api_test
{
    public class VehicleRequestControllerTest
    {
        VehicleRequestController _controller;
        IVehicleRequestHandler _handler;

        public VehicleRequestControllerTest()
        {
            _handler = new VehicleRequestHandler();
            _controller = new VehicleRequestController(_handler);
        }

        [Fact]
        public void Post_WhenCalled_ReturnsValidResult()
        {
            //Arrange
            var nameMissingItem = new VehicleRequest() { VehicleId = 10, ManufacturerNameShort = "Shortname", Price = 100, Type = "Manufacturer" };
            //Act
            var validResult = _controller.ProcessVehicle(nameMissingItem);
            //Assert
            Assert.IsType<ProcessVehicleResponse>(validResult);
            Assert.Equal(10, validResult.VehicleId);
            Assert.Equal("Valid", validResult.ReturnCode.Name);
        }
        [Fact]
        public void Post_WhenCalled_ReturnsInvalidResult()
        {
            //Arrange
            var nameMissingItem = new VehicleRequest() { VehicleId = 30, ManufacturerNameShort = "", Price = 100, Type = "" };
            //Act
            var invalidResult = _controller.ProcessVehicle(nameMissingItem);
            //Assert
            Assert.IsType<ProcessVehicleResponse>(invalidResult);
            Assert.Equal(30, invalidResult.VehicleId);
            Assert.Equal("Invalid", invalidResult.ReturnCode.Name);
        }
    }
}
