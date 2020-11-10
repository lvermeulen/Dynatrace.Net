using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ScopeConditions
	{
		[JsonConverter(typeof(ServiceTechnologiesConverter))]
		public ServiceTechnologies? ServiceTechnology { get; set; }
		public string ProcessGroup { get; set; }
		public string HostGroup { get; set; }
		public string TagOfProcessGroup { get; set; }
	}
}
