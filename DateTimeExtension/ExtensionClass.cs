

using System;

namespace DateTimeExtension
{
    public static class ExtensionClass
    {
        public static bool IsWeekPassed(this DateTime date)
        {
            return StartOfWeek(date, DayOfWeek.Monday) < StartOfWeek(DateTime.UtcNow, DayOfWeek.Monday);
        }
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
