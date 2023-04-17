using Hangfire;
using OrderSystemChallange.API.RecurringJobs;

namespace OrderSystemChallange.API.Schedules
{
    public static class RecurringJobs
    {
        [Obsolete]
        public static void HourlyCarrierReport()
        {

            RecurringJob.RemoveIfExists(nameof(CarrierReport));
            RecurringJob.AddOrUpdate<CarrierReport>(nameof(CarrierReport),
                job => job.Process(), Cron.Hourly, TimeZoneInfo.Local);
        }
    }
}
