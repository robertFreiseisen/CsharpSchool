using Chinook.Contracts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Chinook.Logic.Models
{
    [CsvMapper.Attributes.DataClass(FileName = "InvoiceLine.csv")]
    public class InvoiceLine : Contracts.Models.IInvoiceLine
    {
        [CsvMapper.Attributes.DataPropatyInfo(NotMapped = true)]
        public IInvoice Invoice { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public int InvoiceId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int InvoiceLineId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 4)]
        public int Quantity { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 2)]
        public int TrackId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 3)]
        public double UnitPrice { get; set; }
    }
}
