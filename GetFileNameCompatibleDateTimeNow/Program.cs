// See https://aka.ms/new-console-template for more information
// Why?
// To reliably get the YearMonthDate_HourMinuteSecond_TimeZone string

using System.Linq;
using System.IO;

namespace Program
{

    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine(DateTimeTools.GenerateDateTime());

        }
    }
}
