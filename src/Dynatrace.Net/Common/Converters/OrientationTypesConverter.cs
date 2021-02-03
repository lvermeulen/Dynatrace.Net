using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class OrientationTypesConverter : JsonEnumConverter<OrientationTypes>
	{
		private static readonly Dictionary<OrientationTypes, string> s_pairs = new Dictionary<OrientationTypes, string>
		{
			[OrientationTypes.Landscape] = "LANDSCAPE",
			[OrientationTypes.Portrait] = "PORTRAIT",
			[OrientationTypes.Unknown] = "UNKNOWN"
		};
		
		protected override Dictionary<OrientationTypes, string> Pairs => s_pairs;

		protected override string EntityString => "orientation type";
	}
}
