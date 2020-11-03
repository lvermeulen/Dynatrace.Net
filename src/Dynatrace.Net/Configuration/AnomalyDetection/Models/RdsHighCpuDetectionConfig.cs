namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class RdsHighCpuDetectionConfig
	{
		public bool? Enabled	 { get; set; }
		public RdsHighCpuThresholds CustomThresholds { get; set; }
	}
}
