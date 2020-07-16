using System;

namespace DotNetUtils.DateAndTime
{
    public static class DateTimeConstants
    {
        public static DateTime GpsEpoch => DateTime.Parse("6 January 1980");

        public static long GpsUtcEpochDeltaSeconds =>
            (long)(GpsEpoch.Subtract(DateTime.UnixEpoch).TotalSeconds);
    }
}
