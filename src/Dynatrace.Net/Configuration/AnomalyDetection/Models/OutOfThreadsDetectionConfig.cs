namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class OutOfThreadsDetectionConfig
	{
		public bool? Enabled { get; set; }
		public OutOfThreadsThresholds CustomThresholds { get; set; }
	}
}
