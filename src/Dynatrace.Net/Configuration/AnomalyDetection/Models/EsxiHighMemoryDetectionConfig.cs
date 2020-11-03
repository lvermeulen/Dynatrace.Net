namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class EsxiHighMemoryDetectionConfig
	{
		public bool? Enabled { get; set; }
		public EsxiHighMemoryThresholds CustomThresholds { get; set; }
	}
}
