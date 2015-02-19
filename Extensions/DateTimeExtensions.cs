using System;

public static class DateTimeExtensions
{
  /// <summary>
  /// Returns true if the system's time zone is now experiencing a period of
  /// Daylight Savings adjustment. e.g. one hour added
  /// </summary>
  public static bool IsDaylightSavingTime()
  {
    return System.TimeZone.CurrentTimeZone.IsDaylightSavingTime(DateTime.Now);
  }
}
