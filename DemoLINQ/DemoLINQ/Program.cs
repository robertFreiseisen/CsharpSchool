using DemoLINQ.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace DemoLINQ
{
    class Program
    {
        static List<Student> Students { get; } = new List<Student>
        {
            new Student{ Id=2012001, Name="John", Subject="Computing"},
            new Student{ Id=2012002, Name="Ann", Subject="Mathematics"},
            new Student{ Id=2014003, Name="Sue", Subject="Computing"},
            new Student{ Id=2015004, Name="Bob", Subject="Mathematics"}
        };
        static List<Marking> Marks { get; } = new List<Marking>
        {
            new Marking{ Id=1, StudentId=2012001, Cours="Programming", Mark=3},
            new Marking{ Id=2, StudentId=2012001, Cours="Databases", Mark=2},
            new Marking{ Id=3, StudentId=2012001, Cours="ComputingGraphics", Mark=1},
            new Marking{ Id=4, StudentId=2012002, Cours="Algebra", Mark=2},
            new Marking{ Id=5, StudentId=2012002, Cours="Analysis", Mark=4},
            new Marking{ Id=6, StudentId=2012002, Cours="Databases", Mark=5},
            new Marking{ Id=7, StudentId=2014003, Cours="Programming", Mark=1},
            new Marking{ Id=8, StudentId=2014003, Cours="Databases", Mark=5},
            new Marking{ Id=9, StudentId=2014003, Cours="ComputingGraphics", Mark=4},
            new Marking{ Id=10, StudentId=2015004, Cours="Algebra", Mark=1},
            new Marking{ Id=11, StudentId=2015004, Cours="Analysis", Mark=2},
            new Marking{ Id=12, StudentId=2015004, Cours="Databases", Mark=2}
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Linq");
            Console.WriteLine();

            var result = from s in Students
                         join m in Marks on s.Id equals m.StudentId
                         group s by s.Subject;

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
            }

            var result1 = from s in Students
                         group s by s.Subject;

            Console.WriteLine();
            foreach (var item in result1)
            {
                Console.WriteLine(item.Key);

                foreach (var item1 in item.Select(s => new { s.Id, s.Name }))
                {
                    Console.WriteLine($"\t{item1.Id}-{item1.Name}");
                }
            }

            var result2 = from s in Students
                          group s by s.Subject into g
                          select new { Subject = g.Key, N = g.Count() };

            Console.WriteLine();
            foreach (var item in result2)
            {
                Console.WriteLine($"{item.Subject} - {item.N}");
            }

            var result3 = from s in Students
                          join m in Marks on s.Id equals m.StudentId
                          select new { s.Name, m.Cours, m.Mark };
            
            Console.WriteLine();
            foreach (var item in result3)
            {
                Console.WriteLine(item.ToString().Replace("{", string.Empty).Replace("}", string.Empty));
            }

            var result4 = from s in Students
                          join m in Marks on s.Id equals m.StudentId into list
                          select new { s.Name, Marks = list };

            Console.WriteLine();
            foreach (var item in result4)
            {
                Console.WriteLine(item.Name);
                foreach (var item1 in item.Marks)
                {
                    Console.WriteLine($"\t{item1.Cours} - {item1.Mark}");
                }
            }

            var result5 = from s in Students
                          let year = s.Id / 1000
                          where year == 2012
                          select s;

            Console.WriteLine();
            foreach (var item in result5)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }

            // Get Studentname, who has a better mark than 5
            var result6 = from s in Students
                          join m in Marks on s.Id equals m.StudentId into list
                          where list.All(m => m.Mark < 5)
                          select s.Name;

            Console.WriteLine();
            foreach (var item in result6)
            {
                Console.WriteLine($"\t{item}");
            }
        }
    }
}
