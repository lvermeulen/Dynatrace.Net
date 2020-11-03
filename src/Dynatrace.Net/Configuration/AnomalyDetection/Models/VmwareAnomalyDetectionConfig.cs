using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class VmwareAnomalyDetectionConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public EsxiHighCpuSaturationConfig EsxiHighCpuSaturation { get; set; }
		public GuestCpuLimitReachedConfig GuestCpuLimitReached { get; set; }
		public EsxiHighMemoryDetectionConfig EsxiHighMemoryDetection { get; set; }
		public OverloadedStorageDetectionConfig OverloadedStorageDetection { get; set; }
		public UndersizedStorageDetectionConfig UndersizedStorageDetection { get; set; }
		public SlowPhysicalStorageDetectionConfig SlowPhysicalStorageDetection { get; set; }
		public DroppedPacketsDetectionConfig DroppedPacketsDetection { get; set; }
		public LowDatastoreSpaceDetectionConfig LowDatastoreSpaceDetection { get; set; }
	}
}
