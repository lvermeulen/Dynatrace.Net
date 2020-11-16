using System.Collections.Generic;
using Dynatrace.Net.Configuration.MaintenanceWindows.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TagCombinationTypesConverter : JsonEnumConverter<TagCombinationTypes>
	{
		private static readonly Dictionary<TagCombinationTypes, string> s_pairs = new Dictionary<TagCombinationTypes, string>
		{
			[TagCombinationTypes.And] = "AND",
			[TagCombinationTypes.Or] = "OR"
		};
		
		protected override Dictionary<TagCombinationTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "tag combination type";
	}
}
