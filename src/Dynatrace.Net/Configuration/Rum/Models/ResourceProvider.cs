using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ResourceProvider
	{
		public string ResourceName { get; set; }
		[JsonConverter(typeof(ProviderResourceTypesConverter))]
		public ProviderResourceTypes? ResourceType { get; set; }
		public string BrandIconUrl { get; set; }
		public IEnumerable<string> DomainNamePatterns { get; set; }
	}
}
