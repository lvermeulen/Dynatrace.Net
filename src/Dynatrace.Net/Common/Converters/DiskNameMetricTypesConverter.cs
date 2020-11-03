using System.Collections.Generic;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class DiskNameMetricTypesConverter : JsonEnumConverter<DiskNameMetricTypes>
	{
		private static readonly Dictionary<DiskNameMetricTypes, string> s_pairs = new Dictionary<DiskNameMetricTypes, string>
		{
			[DiskNameMetricTypes.LowDiskSpace] = "LOW_DISK_SPACE",
			[DiskNameMetricTypes.LowInodes] = "LOW_INODES",
			[DiskNameMetricTypes.ReadTimeExceeding] = "READ_TIME_EXCEEDING",
			[DiskNameMetricTypes.WriteTimeExceeding] = "WRITE_TIME_EXCEEDING"
		};

		protected override Dictionary<DiskNameMetricTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "metric type";
	}
}
