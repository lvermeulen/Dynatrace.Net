using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class DatabaseAnomalyDetectionConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public ResponseTimeDegradationDetectionConfig ResponseTimeDegradation { get; set; }
		public LoadDropDetectionConfig LoadDrop { get; set; }
		public LoadSpikeDetectionConfig LoadSpike { get; set; }
		public FailureRateIncreaseDetectionConfig FailureRateIncrease { get; set; }
		public DatabaseConnectionFailureDetectionConfig DatabaseConnectionFailureCount { get; set; }
	}
}
