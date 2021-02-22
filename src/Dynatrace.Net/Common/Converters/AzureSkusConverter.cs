using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AzureSkusConverter : JsonEnumConverter<AzureSkus>
	{
		private static readonly Dictionary<AzureSkus, string> s_pairs = new Dictionary<AzureSkus, string>
		{
			[AzureSkus.Basic] = "BASIC",
			[AzureSkus.Dynamic] = "DYNAMIC",
			[AzureSkus.Free] = "FREE",
			[AzureSkus.Premium] = "PREMIUM",
			[AzureSkus.Shared] = "SHARED",
			[AzureSkus.Standard] = "STANDARD"
		};

		protected override Dictionary<AzureSkus, string> Pairs => s_pairs;

		protected override string EntityString => "Azure SKU";
	}
}
