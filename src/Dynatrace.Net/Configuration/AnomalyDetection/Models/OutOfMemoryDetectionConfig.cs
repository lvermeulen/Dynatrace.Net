namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class OutOfMemoryDetectionConfig
	{
		public bool? Enabled { get; set; }
		public OutOfMemoryThresholds CustomThresholds { get; set; }
	}
}
