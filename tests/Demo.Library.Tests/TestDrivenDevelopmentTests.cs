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
            var employee = Fixture.Create<Employee>();

            employee.Deactivate();

            employee.IsActive.ShouldBeFalse();
        }

        [Fact]
        public void Deactivate_Also_Refresh_UpdatedDate()
        {
            var employee = Fixture.Build<Employee>()
                .With(x => x.UpdatedAt, DateTimeOffset.Now.AddDays(2))
                .Create();

            employee.Deactivate();

            employee.IsActive.ShouldBeFalse();
            employee.UpdatedAt.Date.ShouldBe(DateTime.Now.Date);
        }

        [Fact]
        public void Can_Activate_Employee()
        {
            // throw new NotImplementedException();
        }

        [Fact]
        public void Activate_Employee_Should_Also_Refresh_Updated_Date()
        {
            // throw new NotImplementedException();
        }
    }
}
