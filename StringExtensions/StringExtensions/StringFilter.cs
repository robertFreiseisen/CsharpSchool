using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class StringFilter
    {
        /// <summary>
        /// Diese Erweiterungsmethode filtert die Zeichenkette mit dem benutzerdefinierten Filter.
        /// </summary>
        /// <param name="source">Die Zeichenkette</param>
        /// <param name="filter">Eine Zeichenkette mit den gefilterten Zeichen der Zeichenkette 'source'</param>
        /// <returns></returns>
        public static string Filter(this string source, Func<char, bool> filter)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append(source.Where(c => filter != null && filter(c)).ToArray());
            return strBuilder.ToString();
        }

        /// <summary>
        /// Diese Erweiterungsmethode filtert alle Ziffern aus einer Zeichenkette.
        /// </summary>
        /// <param name="source">Die Zeichenkette</param>
        /// <returns>Eine Zeichenkette mit allen Ziffern aus der Zeichenkette 'source'</returns>
        public static string FilterDigits(this string source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append(source.Where(c => Char.IsDigit(c)).ToArray());
            return strBuilder.ToString();
        }

        /// <summary>
        /// Diese Erweiterungsmethode filtert alle Buchstaben aus einer Zeichenkette. 
        /// </summary>
        /// <param name="source">Die Zeichenkette</param>
        /// <returns>Eine Zeichenkette mit allen Buchstaben aus der Zeichenkette 'source'</returns>
        public static string FilterLetters(this string source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append(source.Where(c => Char.IsLetter(c)).ToArray());
            return strBuilder.ToString();
        }
    }
}
