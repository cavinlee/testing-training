using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using Shouldly;
using Xunit;

namespace Demo.Library.Tests
{
    public class VehicleTests
    {
        protected readonly IFixture Fixture;

        public VehicleTests()
        {
            Fixture = new Fixture();
        }

        [Fact]
        public void Vehicle_Must_Have_PlateNo()
        {
            var vehicle = Fixture.Create<Vehicle>();

            // vehicle.PlateNo = "ABC123";

            vehicle.PlateNo.ShouldNotBeNullOrWhiteSpace();
        }

        [Fact]
        public void Vehicle_Can_Open_Door()
        {
            var vehicle = Fixture.Create<Vehicle>();

            vehicle.Open();

            vehicle.IsOpened.ShouldBeTrue();
        }

        [Fact]
        public void Vehicle_Can_Close_Door()
        {
            var vehicle = Fixture.Create<Vehicle>();

            vehicle.Close();

            vehicle.IsOpened.ShouldBeFalse();
        }
        [Fact]
        public void Cannot_Move_When_Vehicle_Door_Is_Open()
        {
            var vehicle = Fixture.Create<Vehicle>();

            Should.Throw<VehicleException>(() =>
            {
                vehicle.Open();
                vehicle.Move(); 
            });
        }

        [Fact]
        public void Can_Move_When_Vehicle_Door_Is_Open_But_Is_ByPassed()
        {
            var vehicle = Fixture.Create<Vehicle>();
            vehicle.BypassSecurity();

            Should.NotThrow(() =>
            {
                vehicle.Open();
                vehicle.Move();
            });
        }
    }
}
