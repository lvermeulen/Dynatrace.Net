using System.Collections.Generic;
using Dynatrace.Net.Environment.ProblemsV1.Models;

namespace Dynatrace.Net.Common.Converters
{
    public class RelativeTimesConverter : JsonEnumConverter<RelativeTimes>
    {
        private static readonly Dictionary<RelativeTimes, string> s_pairs = new Dictionary<RelativeTimes, string>
        {
            [RelativeTimes._10mins] = "10mins",
            [RelativeTimes._15mins] = "15mins",
            [RelativeTimes._2hours] = "2hours",
            [RelativeTimes._30mins] = "30mins",
            [RelativeTimes._3days] = "3days",
            [RelativeTimes._5mins] = "5mins",
            [RelativeTimes._6hours] = "6hours",
            [RelativeTimes.Day] = "day",
            [RelativeTimes.Hour] = "hour",
            [RelativeTimes.Min] = "min",
            [RelativeTimes.Month] = "month",
            [RelativeTimes.Week] = "week"
        };

        protected override Dictionary<RelativeTimes, string> Pairs => s_pairs;

        protected override string EntityString => "relativeTime";
    }
}
