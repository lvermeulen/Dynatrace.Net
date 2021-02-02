using System.Collections.Generic;

namespace Dynatrace.Net.Environment.OneAgentOnAHost.Models
{
	public class PluginInfo
	{
		public string PluginName { get; set; }
		public IEnumerable<PluginInstance> Instances { get; set; }
	}
}
