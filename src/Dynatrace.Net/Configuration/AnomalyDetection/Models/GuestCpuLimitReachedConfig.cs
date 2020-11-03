namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class GuestCpuLimitReachedConfig
	{
		public bool? Enabled { get; set; }
		public GuestCpuLimitThresholds CustomThresholds { get; set; }
	}
}
