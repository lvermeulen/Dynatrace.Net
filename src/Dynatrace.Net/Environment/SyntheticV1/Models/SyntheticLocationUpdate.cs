using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class SyntheticLocationUpdate
	{
		[JsonConverter(typeof(SyntheticLocationTypesConverter))]
		public SyntheticLocationTypes? Type { get; set; }
	}
}
