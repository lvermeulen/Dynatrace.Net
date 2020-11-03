namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class EsxiHighCpuThresholds
	{
		public int? CpuUsagePercentage { get; set; }
		public int? VmCpuReadyPercentage { get; set; }
		public int? CpuPeakPercentage { get; set; }
	}
}
