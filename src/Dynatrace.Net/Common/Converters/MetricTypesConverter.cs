using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricTypesConverter : JsonEnumConverter<MetricTypes>
	{
		private static readonly Dictionary<MetricTypes, string> s_pairs = new Dictionary<MetricTypes, string>
		{
			[MetricTypes.ReportedErrorCount] = "REPORTED_ERROR_COUNT",
			[MetricTypes.UserActionDuration] = "USER_ACTION_DURATION",
			[MetricTypes.WebRequestCount] = "WEB_REQUEST_COUNT",
			[MetricTypes.WebRequestErrorCount] = "WEB_REQUEST_ERROR_COUNT"
		};

		protected override Dictionary<MetricTypes, string> Pairs => s_pairs;

		protected override string EntityString => "metric type";
	}
}
