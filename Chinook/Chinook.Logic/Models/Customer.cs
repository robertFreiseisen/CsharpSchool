using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chinook.Logic.Models
{ 
    [CsvMapper.Attributes.DataClass(FileName = "Customer.csv")]
    public class Customer : Contracts.Models.ICustomer
    {
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 4)]
        public string Adress { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 5)]
        public string City { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo( OrderPosition = 3)]
        public string Company { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 7)]
        public string Country { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int CustomerId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 11)]
        public string Email { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(OrderPosition = 10)]
        public string Fax { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public string FirstName { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 2)]
        public string LastName { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(OrderPosition = 9)]
        public string Phone { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo( OrderPosition = 8)]
        public string PostalCode { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = false, OrderPosition = 6)]
        public string State { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 12)]
        public int SupportRepId { get; set; }
    }
}
