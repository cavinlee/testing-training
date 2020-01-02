using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture;
using Shouldly;
using Xunit;

namespace Demo.Library.Tests
{
    public class EmployeeTests
    {
        protected readonly IFixture Fixture;

        public EmployeeTests()
        {
            Fixture = new Fixture();
        }

        [Fact]
        public void Employee_Can_Be_Copied()
        {
            var employee = Fixture.Create<Employee>();

            var copiedEmployee = new Employee();

            copiedEmployee.Copy(employee);

            copiedEmployee.DistinguishedName.ShouldBe(employee.DistinguishedName);

            copiedEmployee.EmployeeId.ShouldBe(employee.EmployeeId);
            copiedEmployee.Filter.ShouldBe(employee.Filter);

            copiedEmployee.Identifier.ShouldBe(employee.Identifier);
            copiedEmployee.Login.ShouldBe(employee.Login);
            copiedEmployee.Name.ShouldBe(employee.Name);
            copiedEmployee.FirstName.ShouldBe(employee.FirstName);
            copiedEmployee.LastName.ShouldBe(employee.LastName);
            copiedEmployee.Email.ShouldBe(employee.Email);
            copiedEmployee.Title.ShouldBe(employee.Title);

            copiedEmployee.Department.ShouldBe(employee.Department);
            copiedEmployee.Division.ShouldBe(employee.Division);
            copiedEmployee.Office.ShouldBe(employee.Office);
            copiedEmployee.PostalCode.ShouldBe(employee.PostalCode);
            copiedEmployee.Site.ShouldBe(employee.Site);
            copiedEmployee.Country.ShouldBe(employee.Country);

            copiedEmployee.Mobile.ShouldBe(employee.Mobile);
            copiedEmployee.OfficeExtension.ShouldBe(employee.OfficeExtension);

            copiedEmployee.ManagerDistinguishedName.ShouldBe(employee.ManagerDistinguishedName);

            copiedEmployee.LastPasswordChanged.ShouldBe(employee.LastPasswordChanged);
            copiedEmployee.LastLoggedIn.ShouldBe(employee.LastLoggedIn);
            copiedEmployee.CreatedAt.ShouldBe(employee.CreatedAt);
            copiedEmployee.UpdatedAt.ShouldBe(employee.UpdatedAt);
        }

        [Fact]
        public void Employee_Is_Active_by_Default_When_Created()
        {
            var employee = Fixture.Build<Employee>().Create();
            employee.IsActive.ShouldBeTrue();
        }
    }
}
