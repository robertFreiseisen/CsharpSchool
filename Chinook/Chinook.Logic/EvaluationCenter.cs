using Chinook.Logic.Models;
using System.Linq;

namespace Chinook.Logic
{
    public class EvaluationCenter
    {
        public static string TrackTimeEvalution()
        {
            var tracks = CsvMapper.Logic.CsvHelper.Read<Models.Track>();

            var maxTimeTrack = (from track in tracks
                                orderby track.Milliseconds descending select track)
                            .FirstOrDefault();

            var minTimeTrack = (from track in tracks
                                orderby track.Milliseconds
                                select track)
                            .FirstOrDefault();

            double avgTime = tracks.Average(f => f.Milliseconds);

            return $"Track - Zeit-Auswertung\nTrack/Titel\t\t\t\t\t\t\t\t" +
                $"Zeit[sec]\n{maxTimeTrack.Name}{maxTimeTrack.Milliseconds / 1000,58}" +
                $"\n{minTimeTrack.Name}\t\t{minTimeTrack.Milliseconds / 1000,40}" +
                $"\nAVG-Time:\t{avgTime / 1000:N2}";
        }

        public static string AlbumTimeEvalution()
        {
            var albums = CsvMapper.Logic.CsvHelper.Read<Album>();
            var tracks = CsvMapper.Logic.CsvHelper.Read<Track>();

            var maxTimeAlbum = (from album in albums
                                join track in tracks on album.AlbumId equals track.AlbumId into list
                                orderby list.Sum(s => s.Milliseconds) descending
                                select new
                                {
                                    Title = album.Title,
                                    Milliseconds = list.Sum(s => s.Milliseconds)
                                }).FirstOrDefault();

            var minTimeAlbum = (from album in albums
                                join track in tracks on album.AlbumId equals track.AlbumId into list
                                orderby list.Sum(s => s.Milliseconds)
                                select new
                                {
                                    Title = album.Title,
                                    Milliseconds = list.Sum(s => s.Milliseconds)
                                }).FirstOrDefault();

            double avgTimeAlbums = (from album in albums
                                    join track in tracks on album.AlbumId equals track.AlbumId into list
                                    orderby list.Sum(s => s.Milliseconds)
                                    select new
                                    {
                                        Title = album.Title,
                                        Milliseconds = list.Sum(s => s.Milliseconds)
                                    }).Average(a => a.Milliseconds);

            return $"Album-Zeit-Auswertung\nTrack/Titel\t\t\t\t\t\t\t\t" +
               $"Zeit[sec]\n{maxTimeAlbum.Title}{maxTimeAlbum.Milliseconds / 1000,66}" +
               $"\n{minTimeAlbum.Title}\t\t{minTimeAlbum.Milliseconds / 1000,24}" +
               $"\nAVG-Time:\t{avgTimeAlbums / 1000:N2}";
        }

        public static string TrackSalesEvualtion()
        {
            var tracks = CsvMapper.Logic.CsvHelper.Read<Track>();
            var invoiceLines = CsvMapper.Logic.CsvHelper.Read<InvoiceLine>();

            var maxTrackSale = (from track in tracks
                               join invoiceLine in invoiceLines on track.TrackId equals invoiceLine.TrackId into list
                               orderby list.Count() descending
                               select new
                               {
                                   Title = track.Name,
                                   Quantity = list.Count()
                               }).FirstOrDefault();

            var minTrackSale = (from track in tracks
                                join invoiceLine in invoiceLines on track.TrackId equals invoiceLine.TrackId into list
                                orderby list.Count()
                                select new
                                {
                                    Title = track.Name,
                                    Quantity = list.Count()
                                }).FirstOrDefault();

            var maxTrackTurnover = (from track in tracks
                                   join invoiceLine in invoiceLines on track.TrackId equals invoiceLine.TrackId into list
                                   orderby list.Count() * track.UnitPrice descending
                                   select new
                                   {
                                       Title = track.Name,
                                       Quantity = list.Count()
                                   }).FirstOrDefault();

            var minTrackTurnover = (from track in tracks
                                    join invoiceLine in invoiceLines on track.TrackId equals invoiceLine.TrackId into list
                                    orderby list.Count() * track.UnitPrice
                                    select new
                                    {
                                        Title = track.Name,
                                        Quantity = list.Count()
                                    }).FirstOrDefault();

            return $"Track-Verkauf-Auswertung\nTrack/Titel\t\t\t\t\t\t\t\t" +
                $"Quantity\n{maxTrackSale.Title}{maxTrackSale.Quantity,62}" +
                $"\n{maxTrackTurnover.Title}\t\t{maxTrackTurnover.Quantity,55}" +
                $"\n{minTrackSale.Title}\t\t{minTrackSale.Quantity,55}" +
                $"\n{minTrackTurnover.Title}\t\t{minTrackTurnover.Quantity,55}";

        }

        public static string CustomerEvulation()
        {
            var customers = CsvMapper.Logic.CsvHelper.Read<Customer>();
            var invoices = CsvMapper.Logic.CsvHelper.Read<Invoice>();
            var maxCustomerTurnover = (from customer in customers
                                      join invoice in invoices on customer.CustomerId equals invoice.CustomerId into list
                                      orderby list.Sum(e => e.Total) descending
                                      select new
                                      {
                                          Name = $"{customer.LastName} {customer.FirstName}",
                                          Turnaround = list.Sum(e => e.Total)
                                      }).FirstOrDefault();

            var minCustomerTurnover = (from customer in customers
                                       join invoice in invoices on customer.CustomerId equals invoice.CustomerId into list
                                       orderby list.Sum(e => e.Total)
                                       select new
                                       {
                                           Name = $"{customer.LastName} {customer.FirstName}",
                                           Turnaround = list.Sum(e => e.Total)
                                       }).FirstOrDefault();

            var avgTurnaround = (from customer in customers
                                 join invoice in invoices on customer.CustomerId equals invoice.CustomerId into list
                                 orderby list.Sum(e => e.Total)
                                 select new
                                 {
                                     Name = $"{customer.LastName} {customer.FirstName}",
                                     Turnaround = list.Sum(e => e.Total)
                                 }).Average(a => a.Turnaround);

            return $"Kunde-Verkauf-Auswertung\nKunde/Name\t\t\t\t\t\t\t\t" +
                $" Umsatz\n{maxCustomerTurnover.Name}{maxCustomerTurnover.Turnaround,68:N2}" +
                $"\n{minCustomerTurnover.Name}\t\t{minCustomerTurnover.Turnaround,55:N2}" +
                $"\nAVG-Turnover:\t{avgTurnaround:N2}";


        }

        public static string GenreSaleEvulation()
        {
            var genres = CsvMapper.Logic.CsvHelper.Read<Genre>();
            var invoiceLines = CsvMapper.Logic.CsvHelper.Read<InvoiceLine>();
            var tracks = CsvMapper.Logic.CsvHelper.Read<Track>();

            var maxGenreTurnover = (from genre in genres
                                    orderby (from track in tracks
                                             where track.GenreId == genre.GenreId
                                             join invoiceLine in invoiceLines on track.TrackId equals invoiceLine.TrackId into list
                                             orderby list.Count()
                                             select new { Quantity = list.Count() }).Sum(a => a.Quantity) descending
                                    select new
                                    {
                                        Name = genre.Name,
                                        Quantity = (from track in tracks
                                         where track.GenreId == genre.GenreId
                                         join invoiceLine in invoiceLines on track.TrackId equals invoiceLine.TrackId into list
                                         orderby list.Count()
                                         select new { Quantity = list.Count() }).Sum(a => a.Quantity)
                                    }).FirstOrDefault();

            var minGenreTurnover = (from genre in genres
                                    orderby (from track in tracks
                                             where track.GenreId == genre.GenreId
                                             join invoiceLine in invoiceLines on track.TrackId equals invoiceLine.TrackId into list
                                             orderby list.Count()
                                             select new { Quantity = list.Count() }).Sum(a => a.Quantity) 
                                    select new
                                    {
                                        Name = genre.Name,
                                        Quantity = (from track in tracks
                                                    where track.GenreId == genre.GenreId
                                                    join invoiceLine in invoiceLines on track.TrackId equals invoiceLine.TrackId into list
                                                    orderby list.Count()
                                                    select new { Quantity = list.Count() }).Sum(a => a.Quantity)
                                    }).FirstOrDefault();


            return $"Genre-Verkauf-Auswertung\nGenre/Name\t\t\t\t\t\t\t\t" +
                $"Quantity\n{maxGenreTurnover.Name}{maxGenreTurnover.Quantity,75}" +
                $"\n{minGenreTurnover.Name}\t\t{minGenreTurnover.Quantity,63}";

        }
    }
}
