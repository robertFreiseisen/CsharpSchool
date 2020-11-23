using System;
using System.Data.SqlTypes;
using System.Linq;      

namespace AnonymeTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AnonymeTypes");
            var s = new { Id = 1, Name = "Huber Max" };
            Console.WriteLine($"{s.Id} - {s.Name}");

            var list = new[]
            {
                new { Id = 1, Name = "Max" },
                new { Id = 2, Name = "Peter" },
                new { Id = 3, Name = "Rob" },
                new { Id = 4, Name = "Hubert"},
                new { Id = 5, Name = "Herbert"}
            };

            var l2 = list.Select(x => x.Id);
            var l3 = list.Select(i => i.Name);
            var l4 = list.Select(x => new { Id = x.Id, Name = x.Name, Age = 25 }).ToList();

            foreach (var item in l4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in l4.Where(e=>e.Name.StartsWith("H")))
            {
                Console.WriteLine(item);
            }
        }
    }
}
