using System.Collections.Generic;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricEventMonitoringStrategyTypesConverter : JsonEnumConverter<MetricEventMonitoringStrategyTypes>
	{
		private static readonly Dictionary<MetricEventMonitoringStrategyTypes, string> s_pairs = new Dictionary<MetricEventMonitoringStrategyTypes, string>
		{
			[MetricEventMonitoringStrategyTypes.AutoAdaptiveBaseline] = "AUTO_ADAPTIVE_BASELINE",
			[MetricEventMonitoringStrategyTypes.StaticThreshold] = "STATIC_THRESHOLD"
		};

		protected override Dictionary<MetricEventMonitoringStrategyTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "metric event monitoring strategy type";
	}
}
