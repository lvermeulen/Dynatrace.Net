using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class Service
	{
		public string EntityId { get; set; }
		public string DisplayName { get; set; }
		public string CustomizedName { get; set; }
		public string DiscoveredName { get; set; }
		public long? FirstSeenTimestamp { get; set; }
		public long? LastSeenTimestamp { get; set; }
		public IEnumerable<TagInfo> Tags { get; set; }
		public object ToRelationships { get; set; }
		public string EsbApplicationName { get; set; }
		public IEnumerable<EntityShortRepresentation> ManagementZones { get; set; }
		public IEnumerable<string> IpAddresses { get; set; }
		public string AkkaActorSystem { get; set; }
		public IEnumerable<string> DatabaseHostNames { get; set; }
		public string RemoteEndpoint { get; set; }
		public string Path { get; set; }
		public string WebServiceNamespace { get; set; }
		[JsonConverter(typeof(AgentTechnologyTypesConverter))]
		public AgentTechnologyTypes? AgentTechnologyType { get; set; }
		public int? Port { get; set; }
		public string WebServerName { get; set; }
		public string ClassName { get; set; }
		public string RemoteServiceName { get; set; }
		public string IibApplicationName { get; set; }
		[JsonConverter(typeof(ServiceTypesConverter))]
		public ServiceTypes? ServiceType { get; set; }
		public IEnumerable<TechnologyInfo> SoftwareTechnologies { get; set; }
		public string WebApplicationId { get; set; }
		public string DatabaseName { get; set; }
		public string ContextRoot { get; set; }
		public string DatabaseVendor { get; set; }
		public string IbmCtgServerName { get; set; }
		public IEnumerable<string> ServiceTechnologyTypes { get; set; }
		public string IbmCtgGatewayUrl { get; set; }
		public string WebServiceName { get; set; }
		public object FromRelationships { get; set; }
	}
}
