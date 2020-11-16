using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class ExtensionDto
	{
		public string Id { get; set; }
		public string Name { get; set; }
		[JsonConverter(typeof(ExtensionTypesConverter))]
		public ExtensionTypes? Type { get; set; }
	}
}
