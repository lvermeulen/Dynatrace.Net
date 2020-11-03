namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class OverloadedStorageDetectionConfig
	{
		public bool? Enabled { get; set; }
		public OverloadedStorageThresholds CustomThresholds { get; set; }
	}
}
