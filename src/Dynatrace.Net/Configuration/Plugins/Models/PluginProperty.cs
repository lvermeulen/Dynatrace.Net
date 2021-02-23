using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Plugins.Models
{
	public class PluginProperty
	{
		public string Key { get; set; }
		public string Type { get; set; }
		public string DefaultValue { get; set; }
		public IEnumerable<string> DropdownValues { get; set; }
	}
}
