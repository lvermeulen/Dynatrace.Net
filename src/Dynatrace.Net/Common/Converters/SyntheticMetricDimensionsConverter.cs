using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SyntheticMetricDimensionsConverter : JsonEnumConverter<SyntheticMetricDimensions>
	{
		private static readonly Dictionary<SyntheticMetricDimensions, string> s_pairs = new Dictionary<SyntheticMetricDimensions, string>
		{
			[SyntheticMetricDimensions.Event] = "Event",
			[SyntheticMetricDimensions.Location] = "Location",
			[SyntheticMetricDimensions.ResourceOrigin] = "ResourceOrigin"
		};

		protected override Dictionary<SyntheticMetricDimensions, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "dimension";
	}
}
