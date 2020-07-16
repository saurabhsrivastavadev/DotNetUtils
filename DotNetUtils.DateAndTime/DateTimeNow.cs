using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DotNetUtils.DateAndTime
{
    public static class DateTimeNow
    {
        public static TimeSpan TimeSinceUtcEpoch => DateTime.UtcNow.Subtract(DateTime.UnixEpoch);

        public static TimeSpan TimeSinceGpsEpoch => DateTime.UtcNow.Subtract(DateTimeConstants.GpsEpoch);

        public static int GetWeekOfYear(DateTime dt)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(
                dt, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public static int GetDayOfYear(DateTime dt)
        {
            return CultureInfo.InvariantCulture.Calendar.GetDayOfYear(dt);
        }

        public static int GetDaysInYear(int year)
        {
            return CultureInfo.InvariantCulture.Calendar.GetDaysInYear(year);
        }

        public static int GetWeeksInYear(int year)
        {
            var dt = new DateTime(year, 12, 31);
            return GetWeekOfYear(dt);
        }
    }
}
