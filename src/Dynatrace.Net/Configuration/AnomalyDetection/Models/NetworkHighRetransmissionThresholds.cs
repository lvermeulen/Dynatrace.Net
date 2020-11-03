namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class NetworkHighRetransmissionThresholds
	{
		public int? RetransmissionRatePercentage { get; set; }
		public int? RetransmittedPacketsNumberPerMinute { get; set; }
	}
}
