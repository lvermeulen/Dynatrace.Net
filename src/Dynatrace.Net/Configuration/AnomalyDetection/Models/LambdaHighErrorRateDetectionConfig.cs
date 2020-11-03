namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class LambdaHighErrorRateDetectionConfig
	{
		public bool? Enabled	 { get; set; }
		public LambdaHighErrorRateThresholds CustomThresholds	 { get; set; }
	}
}
