namespace GISA.Helper
{
    public static class DateTimeExtensions
    {
        public static DateTime GetCurrentDateTimeInBrazil(this DateTime dateTime)
        {
            TimeZoneInfo brazilTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, brazilTimeZone);
        }
    }
}
