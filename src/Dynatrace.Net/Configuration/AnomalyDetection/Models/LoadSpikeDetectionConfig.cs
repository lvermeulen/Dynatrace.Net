namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class LoadSpikeDetectionConfig
	{
		public bool? Enabled { get; set; }
		public int? LoadSpikePercent { get; set; }
		public int? MinAbnormalStateDurationInMinutes { get; set; }
	}
}
