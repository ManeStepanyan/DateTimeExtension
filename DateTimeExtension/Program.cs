using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = new DateTime(2020, 7, 25); // false
            var date2 = new DateTime(2020, 7, 20); // false
            var date3 = new DateTime(2021, 7, 20); // false
            var date4 = new DateTime(2020, 7, 19); // true
            Console.WriteLine($"1:{date1.IsWeekPassed()}\n2:{date2.IsWeekPassed()}\n3:{date3.IsWeekPassed()}\n4:{date4.IsWeekPassed()}");
            Console.ReadLine();
        }
    }
}
