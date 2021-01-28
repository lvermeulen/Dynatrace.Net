using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.AutoTags.Models
{
	public class AutoTag
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string Name { get; set; }
		public IEnumerable<AutoTagRule> Rules { get; set; }
	}
}
