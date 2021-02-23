using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ProviderResourceTypesConverter : JsonEnumConverter<ProviderResourceTypes>
	{
		private static readonly Dictionary<ProviderResourceTypes, string> s_pairs = new Dictionary<ProviderResourceTypes, string>
		{
			[ProviderResourceTypes.CdnResources] = "CDN_RESOURCES",
			[ProviderResourceTypes.FirstPartyResources] = "FIRST_PARTY_RESOURCES",
			[ProviderResourceTypes.ThirdPartyResources] = "THIRD_PARTY_RESOURCES"
		};

		protected override Dictionary<ProviderResourceTypes, string> Pairs => s_pairs;

		protected override string EntityString => "provider resource type";
	}
}
