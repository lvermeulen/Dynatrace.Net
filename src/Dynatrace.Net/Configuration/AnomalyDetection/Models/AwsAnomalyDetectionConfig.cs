using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class AwsAnomalyDetectionConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public RdsHighCpuDetectionConfig RdsHighCpuDetection { get; set; }
		public RdsHighWriteReadLatencyDetectionConfig RdsHighWriteReadLatencyDetection { get; set; }
		public RdsLowStorageDetectionConfig RdsLowStorageDetection { get; set; }
		public RdsHighMemoryDetectionConfig RdsHighMemoryDetection { get; set; }
		public ElbHighConnectionErrorsDetectionConfig ElbHighConnectionErrorsDetection { get; set; }
		public RdsRestartsSequenceDetectionConfig RdsRestartsSequenceDetection { get; set; }
		public LambdaHighErrorRateDetectionConfig LambdaHighErrorRateDetection { get; set; }
		public Ec2CandidateCpuSaturationDetectionConfig Ec2CandidateCpuSaturationDetection { get; set; }
	}
}
