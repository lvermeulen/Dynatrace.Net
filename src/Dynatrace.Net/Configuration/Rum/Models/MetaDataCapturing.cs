using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class MetaDataCapturing
	{
		[JsonConverter(typeof(MetadataTypesConverter))]
		public MetadataTypes? Type { get; set; }
		public string CapturingName { get; set; }
		public string Name { get; set; }
		public int? UniqueId { get; set; }
		public bool? PublicMetadata { get; set; }
	}
}
