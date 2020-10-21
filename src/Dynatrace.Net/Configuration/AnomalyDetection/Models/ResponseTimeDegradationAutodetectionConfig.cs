namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class ResponseTimeDegradationAutodetectionConfig
	{
		public int? ResponseTimeDegradationMilliseconds { get; set; }
		public int? ResponseTimeDegradationPercent { get; set; }
		public int? SlowestResponseTimeDegradationMilliseconds { get; set; }
		public int? SlowestResponseTimeDegradationPercent { get; set; }
		public string LoadThreshold { get; set; }
	}
}
