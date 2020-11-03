namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class NetworkTcpProblemsDetectionConfig
	{
		public bool? Enabled { get; set; }
		public NetworkTcpProblemsThresholds CustomThresholds { get; set; }
	}
}
