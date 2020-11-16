using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class ExtensionProperty
	{
		public string Key { get; set; }
		public string Type { get; set; }
		public string DefaultValue { get; set; }
		public IEnumerable<string> DropdownValues { get; set; }
	}
}
