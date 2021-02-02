using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class ThirdPartySyntheticTests
	{
		public string SyntheticEngineName { get; set; }
		public string SyntheticEngineIconUrl { get; set; }
		public int? MessageTimestamp { get; set; }
		public IEnumerable<ThirdPartySyntheticLocation> Locations { get; set; }
		public IEnumerable<ThirdPartySyntheticMonitor> Tests { get; set; }
		public IEnumerable<ThirdPartySyntheticTestResult> TestResults { get; set; }
	}
}
