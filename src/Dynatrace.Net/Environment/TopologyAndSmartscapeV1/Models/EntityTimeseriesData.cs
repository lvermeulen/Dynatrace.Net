using System.Collections.Generic;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class EntityTimeseriesData
	{
		public string TimeseriesId { get; set; }
		public object Dimensions { get; set; }
		public IEnumerable<object> DataPoints { get; set; }
	}
}
