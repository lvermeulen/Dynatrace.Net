namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class HighGcActivityDetectionConfig
	{
		public bool? Enabled { get; set; }
		public HighGcActivityThresholds CustomThresholds { get; set; }
	}
}
