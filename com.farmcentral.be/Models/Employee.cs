using System;
using System.Collections.Generic;

#nullable disable

namespace com.farmcentral.be.Models
{
    public partial class Employee
    {
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
    }
}
