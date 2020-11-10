using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class StringPositionsConverter : JsonEnumConverter<StringPositions>
	{
		private static readonly Dictionary<StringPositions, string> s_pairs = new Dictionary<StringPositions, string>
		{
			[StringPositions.After] = "AFTER",
			[StringPositions.Before] = "BEFORE",
			[StringPositions.Between] = "BETWEEN"
		};

		protected override Dictionary<StringPositions, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "string position";
	}
}
