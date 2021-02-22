using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;
using Dynatrace.Net.Configuration.Extensions.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class Host
	{
		public string EntityId { get; set; }
		public string DisplayName { get; set; }
		public string CustomizedName { get; set; }
		public string DiscoveredName { get; set; }
		public int? FirstSeenTimestamp { get; set; }
		public int? LastSeenTimestamp { get; set; }
		public IEnumerable<TagInfo> Tags { get; set; }
		public object ToRelationships { get; set; }
		public IEnumerable<string> GcePublicIpAddresses { get; set; }
		public HostGroup HostGroup { get; set; }
		public string GceMachineType { get; set; }
		public string GceProject { get; set; }
		public string KubernetesCluster { get; set; }
		public string CloudPlatformVendorVersion { get; set; }
		public string AutoScalingGroup { get; set; }
		public string EsxiHostName { get; set; }
		[JsonConverter(typeof(HostOsArchitecturesConverter))]
		public HostOsArchitectures? OsArchitecture { get; set; }
		public string GceProjectId { get; set; }
		public string OpenStackInstaceType { get; set; }
		public string GceInstanceName { get; set; }
		[JsonConverter(typeof(HypervisorTypesConverter))]
		public HypervisorTypes? HypervisorType { get; set; }
		public string AwsInstanceId { get; set; }
		public string OpenstackAvZone { get; set; }
		public IEnumerable<string> AzureHostNames { get; set; }
		public IEnumerable<string> IpAddresses { get; set; }
		[JsonConverter(typeof(HostMonitoringModesConverter))]
		public HostMonitoringModes? MonitoringMode { get; set; }
		public string AmiId { get; set; }
		public string BoshInstanceId { get; set; }
		public string BoshAvailabilityZone { get; set; }
		public string GcpZone { get; set; }
		public int? ZosTotalGeneralPurposeProcessors { get; set; }
		public string LocalHostName { get; set; }
		public int? LogicalCpuCores { get; set; }
		public IEnumerable<string> AwsSecurityGroup { get; set; }
		[JsonConverter(typeof(HostUserLevelsConverter))]
		public HostUserLevels? UserLevel { get; set; }
		public int? ZosTotalPhysicalMemory { get; set; }
		public IEnumerable<string> AzureSiteNames { get; set; }
		public IEnumerable<AgentVersion> PaasAgentVersions { get; set; }
		public IEnumerable<TechnologyInfo> SoftwareTechnologies { get; set; }
		public string BoshName { get; set; }
		public int? SimultaneousMultithreading { get; set; }
		public string OneAgentCustomHostName { get; set; }
		public string OpenstackProjectName { get; set; }
		public bool? IsMonitoringCandidate { get; set; }
		public string BoshDeploymentId { get; set; }
		public string PublicHostName { get; set; }
		public string BoshStemcellVersion { get; set; }
		public string LocalIp { get; set; }
		public string ConsumedHostUnits { get; set; }
		public string GceInstanceId { get; set; }
		public string AwsNameTag { get; set; }
		public int? PaasMemoryLimit { get; set; }
		public string ScaleSetName { get; set; }
		[JsonConverter(typeof(HostCloudTypesConverter))]
		public HostCloudTypes? CloudType { get; set; }
		public string AzureVmName { get; set; }
		public string OpenstackVmName { get; set; }
		public AgentVersion AgentVersion { get; set; }
		public string ZosCpuModelNumber { get; set; }
		public object KubernetesLabels { get; set; }
		[JsonConverter(typeof(HostPaasTypesConverter))]
		public HostPaasTypes? PaasType { get; set; }
		public int? ZosTotalZiipProcessors { get; set; }
		public string BoshInstanceName { get; set; }
		public string PublicIp { get; set; }
		[JsonConverter(typeof(AzureComputeModeNamesConverter))]
		public AzureComputeModeNames? AzureComputeModeName { get; set; }
		public string ZosVirtualization { get; set; }
		public string NetworkZoneId { get; set; }
		[JsonConverter(typeof(AzureSkusConverter))]
		public AzureSkus? AzureSku { get; set; }
		public string OpenstackComputeNodeName { get; set; }
		public IEnumerable<EntityShortRepresentation> ManagementZones { get; set; }
		public string BeanstalkEnvironmentName { get; set; }
		public string AwsInstanceType { get; set; }
		public int? LogicalCpus { get; set; }
		public string ZosCpuSerialNumber { get; set; }
		[JsonConverter(typeof(OsTypesConverter))]
		public OsTypes? OsType { get; set; }
		public string OsVersion { get; set; }
		public string VmwareName { get; set; }
		public string KubernetesNode { get; set; }
		public int? CpuCores { get; set; }
		public int? VirtualCpus { get; set; }
		[JsonConverter(typeof(HostBitnessTypesConverter))]
		public HostBitnessTypes? Bitness { get; set; }
		public IEnumerable<string> OpenstackSecurityGroups { get; set; }
		public object FromRelationships { get; set; }
	}
}
