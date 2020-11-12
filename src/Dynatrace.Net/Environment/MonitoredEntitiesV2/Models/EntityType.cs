using System.Collections.Generic;

namespace Dynatrace.Net.Environment.MonitoredEntitiesV2.Models
{
	public class EntityType
	{
		public IEnumerable<FromPosition> ToRelationships { get; set; }
		public IEnumerable<ToPosition> FromRelationships { get; set; }
		public string Tags { get; set; }
		public string ManagementZones { get; set; }
		public IEnumerable<EntityTypePropertyDto> Properties { get; set; }
		public string Type { get; set; }
	}
}
