using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.RemoteEnvironments.Models
{
	public abstract class RemoteEnvironmentConfigBase
	{
		[JsonConverter(typeof(NetworkScopesConverter))]
		public NetworkScopes? NetworkScope { get; set; }
		public string Id { get; set; }
		public string Uri { get; set; }
	}
}