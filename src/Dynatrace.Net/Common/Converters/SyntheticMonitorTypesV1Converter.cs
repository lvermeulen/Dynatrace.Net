using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SyntheticMonitorTypesV1Converter : JsonEnumConverter<SyntheticMonitorTypesV1>
	{
		private static readonly Dictionary<SyntheticMonitorTypesV1, string> s_pairs = new Dictionary<SyntheticMonitorTypesV1, string>
		{
			[SyntheticMonitorTypesV1.Browser] = "BROWSER",
			[SyntheticMonitorTypesV1.Http] = "HTTP"
		};
		
		protected override Dictionary<SyntheticMonitorTypesV1, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "synthetic monitor type";
	}
}
