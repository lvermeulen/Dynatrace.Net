using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PatternSearchTypesConverter : JsonEnumConverter<PatternSearchTypes>
	{
		private static readonly Dictionary<PatternSearchTypes, string> s_pairs = new Dictionary<PatternSearchTypes, string>
		{
			[PatternSearchTypes.First] = "FIRST",
			[PatternSearchTypes.Last] = "LAST"
		};

		protected override Dictionary<PatternSearchTypes, string> Pairs => s_pairs;

		protected override string EntityString => "pattern search type";
	}
}
