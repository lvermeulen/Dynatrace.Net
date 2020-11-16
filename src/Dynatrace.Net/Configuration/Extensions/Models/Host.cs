using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class Host
	{
		public string Name { get; set; }
		public string Id { get; set; }
		public HostGroup HostGroup { get; set; }
		public IEnumerable<TagInfo> Tags { get; set; }
		public IEnumerable<EntityShortRepresentation> ManagementZones { get; set; }
	}
}
