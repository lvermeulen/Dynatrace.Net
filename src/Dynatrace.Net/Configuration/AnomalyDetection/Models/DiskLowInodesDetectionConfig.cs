namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class DiskLowInodesDetectionConfig
	{
		public bool? Enabled { get; set; }
		public DiskLowInodesThresholds CustomThresholds { get; set; }
	}
}
