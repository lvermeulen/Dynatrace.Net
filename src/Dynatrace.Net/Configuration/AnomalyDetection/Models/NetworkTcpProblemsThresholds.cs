namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class NetworkTcpProblemsThresholds
	{
		public int? NewConnectionFailuresPercentage { get; set; }
		public int? FailedConnectionsNumberPerMinute { get; set; }
	}
}
