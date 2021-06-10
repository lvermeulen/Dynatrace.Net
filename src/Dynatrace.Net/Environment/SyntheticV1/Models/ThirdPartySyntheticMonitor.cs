using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class ThirdPartySyntheticMonitor
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string TestSetup { get; set; }
		public long? ExpirationTimestamp { get; set; }
		public string DrilldownLink { get; set; }
		public string EditLink { get; set; }
		public bool? Enabled { get; set; }
		public bool? Deleted { get; set; }
		public IEnumerable<SyntheticTestLocation> Locations { get; set; }
		public IEnumerable<SyntheticTestStep> Steps { get; set; }
		public int? ScheduleIntervalInSeconds { get; set; }
		public int? NoDataTimeout { get; set; }
	}
}
