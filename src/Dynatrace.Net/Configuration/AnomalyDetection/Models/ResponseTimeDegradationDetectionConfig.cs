namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class ResponseTimeDegradationDetectionConfig
	{
		public string DetectionMode { get; set; }
		public ResponseTimeDegradationAutodetectionConfig AutomaticDetection { get; set; }
		public ResponseTimeDegradationThresholdConfig Thresholds { get; set; }
	}
}
