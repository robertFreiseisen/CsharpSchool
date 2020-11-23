using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models
{
    [CsvMapper.Attributes.DataClass(FileName = "Genre.csv")]
    public class Genre : Contracts.Models.IGenre
    {
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int GenreId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public string Name { get; set; }
    }
}
