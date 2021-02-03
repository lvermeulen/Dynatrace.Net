using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AwsCredentials.Models
{
	public class AwsSupportingServiceMetric
	{
		public string Name { get; set; }
		[JsonConverter(typeof(StatisticsConverter))]
		public Statistics? Statistic { get; set; }
		public IEnumerable<string> Dimensions { get; set; }
	}
}
