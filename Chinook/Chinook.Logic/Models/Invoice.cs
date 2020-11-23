using Chinook.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chinook.Logic.Models
{
    [CsvMapper.Attributes.DataClass(FileName = "Invoice.csv")]
    public class Invoice : Contracts.Models.IInvoice
    {
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 4)]
        public string BillingCity { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 6)]
        public string BillingCountry { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(OrderPosition = 7)]
        public string BillingPostalCode { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(OrderPosition = 5)]
        public string BillingState { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public int CustomerId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 2)]
        public string InvoiceDate { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int InvoiceId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 8)]
        public double Total { get; set; }
    }
}
