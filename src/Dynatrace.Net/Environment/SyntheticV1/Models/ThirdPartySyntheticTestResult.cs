using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class ThirdPartySyntheticTestResult
	{
		public string Id { get; set; }
		public int? ScheduleIntervalInSeconds { get; set; }
		public int? TotalStepCount { get; set; }
		public IEnumerable<ThirdPartySyntheticLocationTestResult> LocationResults { get; set; }
	}
}
