namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class ResponseTimeDegradationThresholdConfig
	{
		public int? ResponseTimeThresholdMilliseconds	 { get; set; }
		public int? SlowestResponseTimeThresholdMilliseconds	 { get; set; }
		public string LoadThreshold	 { get; set; }
		public string Sensitivity	 { get; set; }
	}
}
