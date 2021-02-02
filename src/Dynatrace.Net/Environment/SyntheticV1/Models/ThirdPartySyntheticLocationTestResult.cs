using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class ThirdPartySyntheticLocationTestResult
	{
		public string Id { get; set; }
		public int? StartTimestamp { get; set; }
		public decimal? SuccessRate { get; set; }
		public bool? Success { get; set; }
		public int? ResponseTimeMillis { get; set; }
		public IEnumerable<SyntheticMonitorStepResult> StepResults { get; set; }
	}
}
