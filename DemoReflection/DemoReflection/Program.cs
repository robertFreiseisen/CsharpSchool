using DemoReflection.Atributs;
using DemoReflection.Atributtes;
using System;
using System.Linq;
using System.Reflection;

namespace DemoReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Reflection");

            PrintType<Person>(null);
            PrintType<Student>(null);
            Person p = new Person();
            Person p1 = CreateInstance<Person>();
            Student s = CreateInstance<Student>();
        }
        static void PrintType<T>(T p)
        {
            Type type = p != null ? p.GetType()
                                  : typeof(T);
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name} members from type: {type.Name}");
           
            var dca = type.GetCustomAttribute<DataClassAttribute>();

            Console.WriteLine($"Type: {type.Name} IsDataClass: {dca != null}");
            
            Console.WriteLine("Properties");
            foreach (var item in type.GetProperties())
            {
                Console.Write($"\t{item.Name} {item.PropertyType.Name} ");
                var dpla = item.GetCustomAttribute<DataPropatyInfo>();
                Console.Write($"IsRequired: {(dpla != null ? dpla.IsRequired : false)}");
                if(item.CanRead)
                    Console.Write(" readable ");

                if(item.CanWrite)
                    Console.Write("writeable");

                Console.WriteLine();
            }

            Console.WriteLine("Methods");
            foreach (var item in type.GetMethods())
            {
                Console.WriteLine($"\t{item.Name}");
            }
        }

        /// <summary>
        /// where T : new() == parameterloser Constructor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        static T CreateInstance<T>() where T : new()
        {
            T result = new T();

            foreach (var item in result.GetType()
                                       .GetProperties()
                                       .Where(p => p.PropertyType == typeof(String)
                                                && p.CanWrite))
            {
                object value = item.GetValue(result);

                if (value == null)
                    item.SetValue(result, String.Empty);
            }

            return result;
        }


    }
}
