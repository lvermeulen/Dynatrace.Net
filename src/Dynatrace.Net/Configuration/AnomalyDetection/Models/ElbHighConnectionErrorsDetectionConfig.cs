namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class ElbHighConnectionErrorsDetectionConfig
	{
		public bool? Enabled { get; set; }
		public ElbHighConnectionErrorsThresholds CustomThresholds { get; set; }
	}
}
