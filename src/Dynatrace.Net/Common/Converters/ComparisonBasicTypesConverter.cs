using System.Collections.Generic;
using Dynatrace.Net.Configuration.ManagementZones.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ComparisonBasicTypesConverter : JsonEnumConverter<ComparisonBasicTypes>
	{
		private static readonly Dictionary<ComparisonBasicTypes, string> s_pairs = new Dictionary<ComparisonBasicTypes, string>
		{
			[ComparisonBasicTypes.ApplicationType] = "APPLICATION_TYPE",
			[ComparisonBasicTypes.AzureComputeMode] = "AZURE_COMPUTE_MODE",
			[ComparisonBasicTypes.AzureSku] = "AZURE_SKU",
			[ComparisonBasicTypes.Bitness] = "BITNESS",
			[ComparisonBasicTypes.CloudType] = "CLOUD_TYPE",
			[ComparisonBasicTypes.CustomApplicationType] = "CUSTOM_APPLICATION_TYPE",
			[ComparisonBasicTypes.DatabaseTopology] = "DATABASE_TOPOLOGY",
			[ComparisonBasicTypes.DcrumDecoderType] = "DCRUM_DECODER_TYPE",
			[ComparisonBasicTypes.EntityId] = "ENTITY_ID",
			[ComparisonBasicTypes.HypervisorType] = "HYPERVISOR_TYPE",
			[ComparisonBasicTypes.IndexedName] = "INDEXED_NAME",
			[ComparisonBasicTypes.IndexedString] = "INDEXED_STRING",
			[ComparisonBasicTypes.IndexedTag] = "INDEXED_TAG",
			[ComparisonBasicTypes.Integer] = "INTEGER",
			[ComparisonBasicTypes.IpAddress] = "IP_ADDRESS",
			[ComparisonBasicTypes.MobilePlatform] = "MOBILE_PLATFORM",
			[ComparisonBasicTypes.OsArchitecture] = "OS_ARCHITECTURE",
			[ComparisonBasicTypes.OsType] = "OS_TYPE",
			[ComparisonBasicTypes.PaasType] = "PAAS_TYPE",
			[ComparisonBasicTypes.ServiceTopology] = "SERVICE_TOPOLOGY",
			[ComparisonBasicTypes.ServiceType] = "SERVICE_TYPE",
			[ComparisonBasicTypes.SimpleHostTech] = "SIMPLE_HOST_TECH",
			[ComparisonBasicTypes.SimpleTech] = "SIMPLE_TECH",
			[ComparisonBasicTypes.String] = "STRING",
			[ComparisonBasicTypes.SyntheticEngineType] = "SYNTHETIC_ENGINE_TYPE",
			[ComparisonBasicTypes.Tag] = "TAG"
		};

		protected override Dictionary<ComparisonBasicTypes, string> Pairs => s_pairs;

		protected override string EntityString => "comparison type";
	}
}
