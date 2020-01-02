using System;
using AutoFixture;
using Shouldly;
using Xunit;

namespace Demo.Library.Tests
{
    public class BasicTests
    {
        [Fact]
        public void Can_See_This_Test_Case_In_Test_Explorer()
        {

        }

        [Theory]
        [InlineData(6, 2, true)]
        [InlineData(6, 3, true)]
        [InlineData(6, 5, false)]
        public void Can_See_These_Parameterized_Test_Case_In_Test_Explorer(int number, int factor, bool isExpected)
        {
            var balance = number % factor;

            var isZero = balance == 0;

            isZero.ShouldBe(isExpected);
        }

        [Fact]
        public void Can_Use_AutoFixture_To_Create_A_Random_Object()
        {
            var fixture = new Fixture();

            var employee = fixture.Create<Employee>();

            employee.ShouldNotBeNull();
            employee.Email.ShouldNotBeNullOrEmpty();
        }
    }
}
