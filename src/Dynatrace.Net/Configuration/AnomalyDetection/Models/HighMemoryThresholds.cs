namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class HighMemoryThresholds
	{
		public int? PageFaultsPerSecondWindows { get; set; }
		public int? UsedMemoryPercentageWindows { get; set; }
		public int? PageFaultsPerSecondNonWindows { get; set; }
		public int? UsedMemoryPercentageNonWindows { get; set; }
	}
}
