using System.Collections.Generic;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricEventDimensionsFilterTypesConverter : JsonEnumConverter<MetricEventDimensionsFilterTypes>
	{
		private static readonly Dictionary<MetricEventDimensionsFilterTypes, string> s_pairs = new Dictionary<MetricEventDimensionsFilterTypes, string>
		{
			[MetricEventDimensionsFilterTypes.Entity] = "ENTITY",
			[MetricEventDimensionsFilterTypes.String] = "STRING"
		};

		protected override Dictionary<MetricEventDimensionsFilterTypes, string> Pairs => s_pairs;

		protected override string EntityString => "metric event dimensions filter type";
	}
}
