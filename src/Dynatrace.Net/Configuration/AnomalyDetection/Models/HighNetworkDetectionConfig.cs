namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class HighNetworkDetectionConfig
	{
		public bool? Enabled { get; set; }
		public HighNetworkThresholds CustomThresholds { get; set; }
	}
}
