using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class MobileSessionUserActionProperty : MobileSessionUserActionPropertyShort
	{
		[JsonConverter(typeof(MobileSessionUserActionPropertyTypesConverter))]
		public MobileSessionUserActionPropertyTypes? Type { get; set; }
		[JsonConverter(typeof(MobileSessionUserActionPropertyOriginsConverter))]
		public MobileSessionUserActionPropertyOrigins? Origin { get; set; }
		[JsonConverter(typeof(MobileSessionUserActionPropertyAggregationsConverter))]
		public MobileSessionUserActionPropertyAggregations? Aggregation { get; set; }
		public bool? StoreAsUserActionProperty { get; set; }
		public bool? StoreAsSessionProperty { get; set; }
		public string CleanupRule { get; set; }
		public string ServerSideRequestAttribute { get; set; }
		public string Name { get; set; }
	}
}
