namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class Ec2CandidateCpuSaturationDetectionConfig
	{
		public bool? Enabled { get; set; }
		public Ec2CandidateCpuSaturationThresholds CustomThresholds { get; set; }
	}
}
