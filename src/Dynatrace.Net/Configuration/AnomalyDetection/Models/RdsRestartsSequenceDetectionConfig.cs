namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class RdsRestartsSequenceDetectionConfig
	{
		public bool? Enabled { get; set; }
		public RdsRestartsThresholds CustomThresholds { get; set; }
	}
}
