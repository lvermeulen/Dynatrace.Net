namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class FailureRateIncreaseAutodetectionConfig
	{
		public int? FailingServiceCallPercentageIncreaseAbsolute { get; set; }
		public int? FailingServiceCallPercentageIncreaseRelative { get; set; }
	}
}
