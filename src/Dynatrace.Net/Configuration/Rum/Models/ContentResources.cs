using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ContentResources
	{
		public IEnumerable<ResourceProvider> ResourceProviders { get; set; }
		public IEnumerable<ResourceUrlCleanupRule> ResourceUrlCleanupRules { get; set; }
		public IEnumerable<ResourceType> ResourceTypes { get; set; }
	}
}
