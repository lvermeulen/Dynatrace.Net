namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class DiskLowSpaceDetectionConfig
	{
		public bool? Enabled { get; set; }
		public DiskLowSpaceThresholds CustomThresholds { get; set; }
	}
}
