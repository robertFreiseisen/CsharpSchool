using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models
{ 
    [CsvMapper.Attributes.DataClass(FileName = "MediaType.csv")]
    public class MediaType : Contracts.Models.IMediaType
    {
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int MediaTypeId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public string Name { get; set; }
    }
}
