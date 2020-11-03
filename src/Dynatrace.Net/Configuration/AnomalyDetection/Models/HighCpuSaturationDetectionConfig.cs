namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class HighCpuSaturationDetectionConfig
	{
		public bool? Enabled { get; set; }
		public HighCpuSaturationThresholds CustomThresholds { get; set; }
	}
}
