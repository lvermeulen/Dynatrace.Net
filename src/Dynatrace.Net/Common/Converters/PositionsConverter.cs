using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PositionsConverter : JsonEnumConverter<Positions>
	{
		private static readonly Dictionary<Positions, string> s_pairs = new Dictionary<Positions, string>
		{
			[Positions.Append] = "APPEND",
			[Positions.Prepend] = "PREPEND"
		};

		protected override Dictionary<Positions, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "position";
	}
}
