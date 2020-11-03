using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class HostsAnomalyDetectionConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public ConnectionLostDetectionConfig ConnectionLostDetection { get; set; }
		public HighCpuSaturationDetectionConfig HighCpuSaturationDetection { get; set; }
		public HighMemoryDetectionConfig HighMemoryDetection { get; set; }
		public HighGcActivityDetectionConfig HighGcActivityDetection { get; set; }
		public OutOfMemoryDetectionConfig OutOfMemoryDetection { get; set; }
		public OutOfThreadsDetectionConfig OutOfThreadsDetection { get; set; }
		public NetworkDroppedPacketsDetectionConfig NetworkDroppedPacketsDetection { get; set; }
		public NetworkErrorsDetectionConfig NetworkErrorsDetection { get; set; }
		public HighNetworkDetectionConfig HighNetworkDetection { get; set; }
		public NetworkTcpProblemsDetectionConfig NetworkTcpProblemsDetection { get; set; }
		public NetworkHighRetransmissionDetectionConfig NetworkHighRetransmissionDetection { get; set; }
		public DiskLowSpaceDetectionConfig DiskLowSpaceDetection { get; set; }
		public DiskSlowWritesAndReadsDetectionConfig DiskSlowWritesAndReadsDetection { get; set; }
		public DiskLowInodesDetectionConfig DiskLowInodesDetection { get; set; }
	}
}
