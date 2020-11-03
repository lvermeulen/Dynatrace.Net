namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class LoadDropDetectionConfig
	{
		public bool? Enabled { get; set; }
		public int? LoadDropPercent { get; set; }
		public int? MinAbnormalStateDurationInMinutes { get; set; }
	}
}
