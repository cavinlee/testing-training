using System;

namespace Demo.Library
{
    public class Employee
    {
        public Employee()
        {
            _IsActive = false;
            CreatedAt = DateTimeOffset.Now;
        }

        public void Copy(Employee employee)
        {
            DistinguishedName = employee.DistinguishedName;

            EmployeeId = employee.EmployeeId;
            Filter = employee.Filter;

            Identifier = employee.Identifier;
            Login = employee.Login;
            Name = employee.Name;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Email = employee.Email;
            Title = employee.Title;

            Department = employee.Department;
            Division = employee.Division;
            Office = employee.Office;
            PostalCode = employee.PostalCode;
            Site = employee.Site;
            Country = employee.Country;

            Mobile = employee.Mobile;
            OfficeExtension = employee.OfficeExtension;

            ManagerDistinguishedName = employee.ManagerDistinguishedName;

            LastPasswordChanged = employee.LastPasswordChanged;
            LastLoggedIn = employee.LastLoggedIn;
            CreatedAt = employee.CreatedAt;
            UpdatedAt = employee.UpdatedAt;
        }

        public virtual string DistinguishedName { get; set; }

        public virtual string Filter { get; set; }
        public virtual string Identifier { get; set; }

        public virtual string EmployeeId { get; set; }
        public virtual string Login { get; set; }
        public virtual string Name { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Title { get; set; }

        public virtual string Department { get; set; }
        public virtual string Division { get; set; }
        public virtual string Office { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Site { get; set; }
        public virtual string Country { get; set; }
        
        public virtual string Mobile { get; set; }
        public virtual string OfficeExtension { get; set; }

        public virtual string ManagerDistinguishedName { get; set; }

        public virtual DateTimeOffset LastPasswordChanged { get; set; }
        public virtual DateTimeOffset LastLoggedIn { get; set; }
        public virtual DateTimeOffset CreatedAt { get; set; }
        public virtual DateTimeOffset UpdatedAt { get; set; }

        private bool _IsActive;
        public virtual bool IsActive => _IsActive;

        public virtual void Update()
        {
            UpdatedAt = DateTimeOffset.Now;
        }

        public void Deactivate()
        {
            _IsActive = false;
            Update();
        }
    }
}