namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class NetworkErrorsDetectionConfig
	{
		public bool? Enabled { get; set; }
		public NetworkErrorsThresholds CustomThresholds { get; set; }
	}
}
