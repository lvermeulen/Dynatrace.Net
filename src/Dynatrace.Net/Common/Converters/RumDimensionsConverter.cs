using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class RumDimensionsConverter : JsonEnumConverter<RumDimensions>
	{
		private static readonly Dictionary<RumDimensions, string> s_pairs = new Dictionary<RumDimensions, string>
		{
			[RumDimensions.ApdexType] = "ApdexType",
			[RumDimensions.Browser] = "Browser",
			[RumDimensions.ErrorContext] = "ErrorContext",
			[RumDimensions.ErrorOrigin] = "ErrorOrigin",
			[RumDimensions.ErrorType] = "ErrorType",
			[RumDimensions.GeoLocation] = "GeoLocation",
			[RumDimensions.StringProperty] = "StringProperty",
			[RumDimensions.UserActionType] = "UserActionType"
		};

		protected override Dictionary<RumDimensions, string> Pairs => s_pairs;

		protected override string EntityString => "dimension";
	}
}
