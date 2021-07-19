using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicasCSharp
{
    class Program
    {
        private static readonly string _dateAsText = "08 07 2021";
        static void Main(string[] args)
        {
            Console.WriteLine(DateWithStringAndSubstring());
            Console.WriteLine(DateWithStringAndSpan());
        }
        public static (int day,int month, int year) DateWithStringAndSubstring()
        {
            var dayAsText = _dateAsText.Substring(0, 2);
            var monthAsText = _dateAsText.Substring(3, 2);
            var yearAsText = _dateAsText.Substring(6);
            var day = int.Parse(dayAsText);
            var month = int.Parse(monthAsText);
            var year = int.Parse(yearAsText);
            return (day, month, year);
        }
        public static (int day, int month, int year) DateWithStringAndSpan()
        {
            ReadOnlySpan<char> dateAsSpan = _dateAsText.AsSpan();
            var dayAsText = dateAsSpan.Slice(0, 2);
            var monthAsText = dateAsSpan.Slice(3, 2);
            var yearAsText = dateAsSpan.Slice(6);
            var day = int.Parse(dayAsText.ToString());
            var month = int.Parse(monthAsText.ToString());
            var year = int.Parse(yearAsText.ToString());
            return (day, month, year);
        }
    }
}
