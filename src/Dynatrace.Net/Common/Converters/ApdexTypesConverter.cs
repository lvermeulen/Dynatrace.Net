using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ApdexTypesConverter : JsonEnumConverter<ApdexTypes>
	{
		private static readonly Dictionary<ApdexTypes, string> s_pairs = new Dictionary<ApdexTypes, string>
		{
			[ApdexTypes.Frustrated] = "Frustrated",
			[ApdexTypes.Satisfied] = "Satisfied",
			[ApdexTypes.Tolerating] = "Tolerating",
			[ApdexTypes.Unknown] = "Unknown"
		};

		protected override Dictionary<ApdexTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "apdex type";
	}
}
