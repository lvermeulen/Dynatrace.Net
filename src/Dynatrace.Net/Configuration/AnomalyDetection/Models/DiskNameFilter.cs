using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class DiskNameFilter
	{
		[JsonConverter(typeof(OperatorsConverter))]
		public Operators? Operator { get; set; }
		public string Value { get; set; }
	}
}
