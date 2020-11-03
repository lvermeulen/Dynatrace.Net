namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class GuestCpuLimitThresholds
	{
		public int? HostCpuUsageMinPercentage { get; set; }
		public int? VmCpuUsageMaxPercentage { get; set; }
		public int? VmCpuReadyMaxPercentage { get; set; }
	}
}
