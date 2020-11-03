namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class HighMemoryDetectionConfig
	{
		public bool? Enabled { get; set; }
		public HighMemoryThresholds CustomThresholds { get; set; }
	}
}
