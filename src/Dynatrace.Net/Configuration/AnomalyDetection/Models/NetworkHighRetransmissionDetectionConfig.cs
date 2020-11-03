namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class NetworkHighRetransmissionDetectionConfig
	{
		public bool? Enabled { get; set; }
		public NetworkHighRetransmissionThresholds CustomThresholds { get; set; }
	}
}
