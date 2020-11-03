namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class EsxiHighCpuSaturationConfig
	{
		public bool? Enabled { get; set; }
		public EsxiHighCpuThresholds CustomThresholds { get; set; }
	}
}
