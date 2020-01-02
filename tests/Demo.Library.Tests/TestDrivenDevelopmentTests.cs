using System;
using AutoFixture;
using Shouldly;
using Xunit;

namespace Demo.Library.Tests
{
    public class TestDrivenDevelopmentTests
    {
        protected readonly IFixture Fixture;

        public TestDrivenDevelopmentTests()
        {
            Fixture = new Fixture();
        }

        [Fact]
        public void Can_Deactivate_Employee()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Can_Activate_Employee()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Activate_Employee_Should_Also_Refresh_Updated_Date()
        {
            throw new NotImplementedException();
        }
    }
}
