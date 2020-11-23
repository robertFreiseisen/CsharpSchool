using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models
{
    [CsvMapper.Attributes.DataClass(FileName = "Playlist.csv")]
    public class Playlist : Contracts.Models.IPlaylist
    {
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int PlaylistId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public string Name { get; set; }
    }
}
