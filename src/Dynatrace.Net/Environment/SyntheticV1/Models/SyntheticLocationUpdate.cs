using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class SyntheticLocationUpdate
	{
		[JsonConverter(typeof(SyntheticLocationTypesConverter))]
		public SyntheticLocationTypes? Type { get; set; }
	}
}
