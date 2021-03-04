using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class UserActionAndSessionProperties
	{
		public string DisplayName { get; set; }
		[JsonConverter(typeof(UserActionAndSessionPropertyTypesConverter))]
		public UserActionAndSessionPropertyTypes? Type { get; set; }
		[JsonConverter(typeof(UserActionAndSessionPropertyOriginsConverter))]
		public UserActionAndSessionPropertyOrigins? Origin { get; set; }
		[JsonConverter(typeof(PatternSearchTypesConverter))]
		public PatternSearchTypes? Aggregation { get; set; }
		public bool? StoreAsUserActionProperty { get; set; }
		public bool? StoreAsSessionProperty { get; set; }
		public string CleanupRule { get; set; }
		public string ServerSideRequestAttribute { get; set; }
		public int? UniqueId { get; set; }
		public string Key { get; set; }
		public int? MetadataId { get; set; }
		public bool? IgnoreCase { get; set; }
	}
}
