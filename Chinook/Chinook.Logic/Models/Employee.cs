using Chinook.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chinook.Logic.Models
{
    [CsvMapper.Attributes.DataClass(FileName = "Employee.csv")]
    public class Employee : Contracts.Models.IEmployee
    {
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 7)]
        public string Address { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 5)]
        public DateTime BirthDate { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 8)]
        public string City { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 10)]
        public string Country { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 15)]
        public string Email { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int EmployeeId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(OrderPosition = 14)]
        public string Fax { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 2)]
        public string FirstName { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 5)]
        public DateTime HireDate { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public string LastName { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 12)]
        public string Phone { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 11)]
        public string PostalCode { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(OrderPosition = 4)]
        public string ReportsTo { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(OrderPosition = 9)]
        public string State { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(NotMapped = true)]
        public string Supervisor { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 3)]
        public string Title { get; set; }
    }
}
