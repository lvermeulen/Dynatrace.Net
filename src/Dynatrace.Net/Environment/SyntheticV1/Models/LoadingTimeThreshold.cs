using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class LoadingTimeThreshold
	{
		[JsonConverter(typeof(LoadingTimeThresholdTypesConverter))]
		public LoadingTimeThresholdTypes? Type { get; set; }
		public int? ValueMs { get; set; }
		public int? RequestIndex { get; set; }
		public int? EventIndex { get; set; }
	}
}
