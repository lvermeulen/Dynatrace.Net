namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class SlowPhysicalStorageThresholds
	{
		public int? AvgReadWriteLatency { get; set; }
		public int? PeakReadWriteLatency { get; set; }
	}
}
