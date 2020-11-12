using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Environment.MonitoredEntitiesV2.Models
{
	public class Entity
	{
		public int? FirstSeenTms { get; set; }
		public int? LastSeenTms { get; set; }
		public object ToRelationships { get; set; }
		public object FromRelationships { get; set; }
		public string EntityId { get; set; }
		public IEnumerable<MeTag> Tags { get; set; }
		public IEnumerable<ManagementZone> ManagementZones { get; set; }
		public object Properties { get; set; }
		public string DisplayName { get; set; }
	}
}
