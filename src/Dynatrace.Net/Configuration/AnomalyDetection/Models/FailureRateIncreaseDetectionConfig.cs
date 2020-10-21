namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class FailureRateIncreaseDetectionConfig
	{
		public string DetectionMode { get; set; }
		public FailureRateIncreaseAutodetectionConfig AutomaticDetection { get; set; }
		public FailureRateIncreaseThresholdConfig Thresholds { get; set; }
	}
}
