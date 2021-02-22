using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AzureComputeModeNamesConverter : JsonEnumConverter<AzureComputeModeNames>
	{
		private static readonly Dictionary<AzureComputeModeNames, string> s_pairs = new Dictionary<AzureComputeModeNames, string>
		{
			[AzureComputeModeNames.Dedicated] = "DEDICATED",
			[AzureComputeModeNames.Shared] = "SHARED"
		};

		protected override Dictionary<AzureComputeModeNames, string> Pairs => s_pairs;

		protected override string EntityString => "Azure compute mode name";
	}
}
