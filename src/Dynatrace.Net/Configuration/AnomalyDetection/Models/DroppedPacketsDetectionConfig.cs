namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class DroppedPacketsDetectionConfig
	{
		public bool? Enabled { get; set; }
		public DroppedPacketsThresholds CustomThresholds { get; set; }
	}
}
