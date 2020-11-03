namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class SlowPhysicalStorageDetectionConfig
	{
		public bool? Enabled { get; set; }
		public SlowPhysicalStorageThresholds CustomThresholds { get; set; }
	}
}
