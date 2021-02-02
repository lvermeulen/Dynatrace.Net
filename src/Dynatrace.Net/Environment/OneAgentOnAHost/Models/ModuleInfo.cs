using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.OneAgentOnAHost.Models
{
	public class ModuleInfo
	{
		[JsonConverter(typeof(TechnologyModuleTypesConverter))]
		public TechnologyModuleTypes? ModuleType { get; set; }
		public IEnumerable<ModuleInstance> Instances { get; set; }
	}
}
