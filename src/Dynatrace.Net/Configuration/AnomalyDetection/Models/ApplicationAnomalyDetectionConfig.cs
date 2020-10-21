using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class ApplicationAnomalyDetectionConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public ResponseTimeDegradationDetectionConfig ResponseTimeDegradation { get; set; }
		public TrafficDropDetectionConfig TrafficDrop { get; set; }
		public TrafficSpikeDetectionConfig TrafficSpike { get; set; }
		public FailureRateIncreaseDetectionConfig FailureRateIncrease { get; set; }
	}
}
