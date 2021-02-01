using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.KubernetesCredentials.Models
{
	public class KubernetesCredentials
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public bool? Active { get; set; }
		[JsonConverter(typeof(KubernetesEndpointStatusTypesConverter))]
		public KubernetesEndpointStatusTypes EndpointStatus { get; set; }
		public string EndpointStatusInfo { get; set; }
		public string Label { get; set; }
		public string EndpointUrl { get; set; }
		public string AuthToken { get; set; }
		public bool? EventsIntegrationEnabled { get; set; }
		public bool? WorkloadIntegrationEnabled { get; set; }
		public bool? PrometheusExportersIntegrationEnabled { get; set; }
		public IEnumerable<KubernetesEventPattern> EventsFieldSelectors { get; set; }
		public bool? CertificateCheckEnabled { get; set; }
	}
}
