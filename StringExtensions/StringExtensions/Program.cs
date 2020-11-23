/* Robert Freiseisen    05.10.2020
 * HTBLA Leonding       4BHIF
 */
using System;
using System.Data.Common;
using System.Diagnostics;

namespace StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hallo 4BHIF";

            

            Console.WriteLine(text.Filter(ch => ch == 'H'));
            Console.WriteLine(text.FilterDigits());
            Console.WriteLine(text.FilterLetters());
        }
    }
}
