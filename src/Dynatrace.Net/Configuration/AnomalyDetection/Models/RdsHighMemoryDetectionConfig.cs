namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class RdsHighMemoryDetectionConfig
	{
		public bool? Enabled { get; set; }
		public RdsHighMemoryThresholds CustomThresholds { get; set; }
	}
}
