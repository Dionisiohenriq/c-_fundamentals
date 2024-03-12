using System.Globalization;

namespace System;

public static class DateTimeExtension
{
    public static string ElapsedTime(this DateTime thisObj)
    {
        TimeSpan duration = DateTime.Now - thisObj;

        if(duration.TotalHours < 24)
        {
            return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
        }
        else
        {
            return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
        }
    }
}
