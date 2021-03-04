using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ProcessingPartsConverter : JsonEnumConverter<ProcessingParts>
	{
		private static readonly Dictionary<ProcessingParts, string> s_pairs = new Dictionary<ProcessingParts, string>
		{
			[ProcessingParts.All] = "ALL",
			[ProcessingParts.Anchor] = "ANCHOR",
			[ProcessingParts.Path] = "PATH"
		};

		protected override Dictionary<ProcessingParts, string> Pairs => s_pairs;

		protected override string EntityString => "processing part";
	}
}
