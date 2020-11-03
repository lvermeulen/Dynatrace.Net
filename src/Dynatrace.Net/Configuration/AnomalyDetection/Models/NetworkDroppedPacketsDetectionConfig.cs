namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class NetworkDroppedPacketsDetectionConfig
	{
		public bool? Enabled { get; set; }
		public NetworkDroppedPacketsThresholds CustomThresholds { get; set; }
	}
}
