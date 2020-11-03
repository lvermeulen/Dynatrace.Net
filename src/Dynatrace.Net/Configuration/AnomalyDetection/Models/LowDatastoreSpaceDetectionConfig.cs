namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class LowDatastoreSpaceDetectionConfig
	{
		public bool? Enabled { get; set; }
		public LowDatastoreSpaceThresholds CustomThresholds { get; set; }
	}
}
