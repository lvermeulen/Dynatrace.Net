using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.OneAgentOnAHost.Models
{
	public class Technology
	{
		[JsonConverter(typeof(TechnologyTypesConverter))]
		public TechnologyTypes? Type { get; set; }
		public bool? MonitoringEnabled { get; set; }
		[JsonConverter(typeof(TechnologyScopesConverter))]
		public TechnologyScopes? Scope { get; set; }
	}
}
