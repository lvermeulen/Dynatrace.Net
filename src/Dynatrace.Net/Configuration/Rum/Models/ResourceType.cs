using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ResourceType
	{
		public string RegularExpression { get; set; }
		[JsonConverter(typeof(ResourceTypesConverter))]
		public ResourceTypes? PrimaryResourceType { get; set; }
		public string SecondaryResourceType { get; set; }
	}
}
