using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class CalculatedMobileMetricDimensionTypesConverter : JsonEnumConverter<CalculatedMobileMetricDimensionTypes>
	{
		private static readonly Dictionary<CalculatedMobileMetricDimensionTypes, string> s_pairs = new Dictionary<CalculatedMobileMetricDimensionTypes, string>
		{
			[CalculatedMobileMetricDimensionTypes.AppVersion] = "APP_VERSION",
			[CalculatedMobileMetricDimensionTypes.Device] = "DEVICE",
			[CalculatedMobileMetricDimensionTypes.ErrorContext] = "ERROR_CONTEXT",
			[CalculatedMobileMetricDimensionTypes.Geolocation] = "GEOLOCATION",
			[CalculatedMobileMetricDimensionTypes.Manufacturer] = "MANUFACTURER",
			[CalculatedMobileMetricDimensionTypes.Os] = "OS"
		};

		protected override Dictionary<CalculatedMobileMetricDimensionTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "dimension type";
	}
}
