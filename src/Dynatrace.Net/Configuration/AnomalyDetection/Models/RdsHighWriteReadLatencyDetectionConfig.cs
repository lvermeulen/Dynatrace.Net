namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class RdsHighWriteReadLatencyDetectionConfig
	{
		public bool? Enabled { get; set; }
		public RdsHighLatencyThresholds CustomThresholds { get; set; }
	}
}
