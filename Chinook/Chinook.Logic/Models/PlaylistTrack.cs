using Chinook.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Logic.Models
{
    [CsvMapper.Attributes.DataClass(FileName = "PlaylistTrack.csv")]
    public class PlaylistTrack : Contracts.Models.IPlaylistTrack
    {
        [CsvMapper.Attributes.DataPropatyInfo(NotMapped = true)]
        public IPlaylist Playlist { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int PlaylistId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public int TrackId { get; set; }
    }
}
