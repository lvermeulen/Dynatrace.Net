namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class SyntheticMonitorStepResult
	{
		public int? Id { get; set; }
		public long? StartTimestamp { get; set; }
		public int? ResponseTimeMillis { get; set; }
		public SyntheticMonitorError Error { get; set; }
	}
}
