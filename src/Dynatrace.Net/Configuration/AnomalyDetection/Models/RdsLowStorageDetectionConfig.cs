namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class RdsLowStorageDetectionConfig
	{
		public bool? Enabled { get; set; }
		public RdsLowStorageThresholds CustomThresholds { get; set; }
	}
}
