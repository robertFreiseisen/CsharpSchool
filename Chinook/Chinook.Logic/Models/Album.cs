using Chinook.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chinook.Logic.Models
{

    [CsvMapper.Attributes.DataClass(FileName ="Album.csv")]
    public class Album : Contracts.Models.IAlbum
    {
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int AlbumId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = false, NotMapped = true)]
        public IArtist Artist { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 2)]
        public int ArtistId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public string Title { get; set; }
    }
}
