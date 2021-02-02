namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class OutageHandlingPolicy
	{
		public bool? GlobalOutage { get; set; }
		public bool? LocalOutage { get; set; }
		public LocalOutagePolicy LocalOutagePolicy { get; set; }
		public bool? RetryOnError { get; set; }
	}
}
