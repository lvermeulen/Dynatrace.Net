namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class UndersizedStorageDetectionConfig
	{
		public bool? Enabled { get; set; }
		public UndersizedStorageThresholds CustomThresholds { get; set; }
	}
}
