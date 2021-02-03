using System.Collections.Generic;
using Dynatrace.Net.Environment.LogMonitoring.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ParsingModesConverter : JsonEnumConverter<ParsingModes>
	{
		private static readonly Dictionary<ParsingModes, string> s_pairs = new Dictionary<ParsingModes, string>
		{
			[ParsingModes.Json] = "json",
			[ParsingModes.Disabled] = "disabled",
			[ParsingModes.All] = "all"
		};

		protected override Dictionary<ParsingModes, string> Pairs => s_pairs;

		protected override string EntityString => "parsing mode";
	}
}
