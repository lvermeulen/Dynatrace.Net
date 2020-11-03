namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class DiskSlowWritesAndReadsDetectionConfig
	{
		public bool? Enabled { get; set; }
		public DiskSlowWriteAndReadsThresholds CustomThresholds { get; set; }
	}
}
