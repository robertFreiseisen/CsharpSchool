using System;

namespace Chinook.Logic.Models
{
    [CsvMapper.Attributes.DataClass(FileName = "Track.csv")]
    public class Track : Contracts.Models.ITrack
    {
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 2)]
        public int AlbumId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 7)]
        public int Bytes { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(OrderPosition = 5)]
        public string Composer { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 4)]
        public int GenreId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 3)]
        public int MediaTypeId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 6)]
        public int Milliseconds { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 1)]
        public string Name { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 0)]
        public int TrackId { get; set; }
        [CsvMapper.Attributes.DataPropatyInfo(IsRequired = true, OrderPosition = 8)]
        public double UnitPrice { get; set; }
    }
}
