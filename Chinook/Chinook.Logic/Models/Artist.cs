using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chinook.Logic.Models
{
    [CsvMapper.Attributes.DataClass(FileName = "Artist.csv")]
    public class Artist : Contracts.Models.IArtist
    {
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int ArtistId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public string Name { get; set; }
    }
}
