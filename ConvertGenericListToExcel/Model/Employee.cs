using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGenericListToExcel.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }

        public static List<Employee> SeedData()
        {
            return new List<Employee>
            {
                new Employee
                {
                    EmployeeID = 1,
                    FirstName = "Test 1",
                    LastName = "Test 1",
                    Phone = "0541414141",
                    Address = "any address within Dubai",
                    City="Dubai",
                    EmailAddress="email1@domain.com"
                },
                 new Employee
                {
                    EmployeeID = 2,
                    FirstName = "Test 2",
                    LastName = "Test 2",
                    Phone = "0541414141",
                    Address = "another address 2",
                    City="Sharjah",
                    EmailAddress="email2@domain.com"
                },
                  new Employee
                {
                    EmployeeID = 3,
                    FirstName = "Test 3",
                    LastName = "Test 3",
                    Phone = "0542325231",
                    Address = "address test 3",
                    City="Abu Dhabi",
                    EmailAddress="email3@domain.com"
                },
                   new Employee
                {
                    EmployeeID = 4,
                    FirstName = "Test 4",
                    LastName = "Test 4",
                    Phone = "0541414141",
                    Address = "new address asdas d4",
                    City="Dubai",
                    EmailAddress="email4@domain.com"
                },
                    new Employee
                {
                    EmployeeID = 1,
                    FirstName = "Test 1",
                    LastName = "Test 1",
                    Phone = "0541414141",
                    Address = "any address within Dubai",
                    City="Dubai",
                    EmailAddress="email5@domain.com"
                },
                     new Employee
                {
                    EmployeeID = 6,
                    FirstName = "Test 6",
                    LastName = "Test 6",
                    Phone = "0549547452",
                    Address = "Al Taawun",
                    City="Abu Dhabi",
                    EmailAddress="email6@domain.com"
                },
            };
        }
    }
}
