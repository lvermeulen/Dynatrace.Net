using System.Collections.Generic;

namespace Dynatrace.Net.Environment.NetworkZones.Models
{
	public class NetworkZone
	{
		public IEnumerable<string> AlternativeZones { get; set; }
		public int? NumOfOneAgentsUsing { get; set; }
		public int? NumOfConfiguredOneAgents { get; set; }
		public int? NumOfOneAgentsFromOtherZones { get; set; }
		public int? NumOfConfiguredActiveGates { get; set; }
		public string Id { get; set; }
		public string Description { get; set; }
	}
}
