using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.UserSessions.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class Application
	{
		public string EntityId { get; set; }
		public string DisplayName { get; set; }
		public string CustomizedName { get; set; }
		public string DiscoveredName { get; set; }
		public int? FirstSeenTimestamp { get; set; }
		public int? LastSeenTimestamp { get; set; }
		public IEnumerable<TagInfo> Tags { get; set; }
		public object FromRelationships { get; set; }
		public object ToRelationships { get; set; }
		public string RuleAppliedPattern { get; set; }
		[JsonConverter(typeof(RuleAppliedMatchTypesConverter))]
		public RuleAppliedMatchTypes? RuleAppliedMatchType { get; set; }
		public IEnumerable<EntityShortRepresentation> ManagementZones { get; set; }
		[JsonConverter(typeof(TopologyApplicationTypesConverter))]
		public TopologyApplicationTypes? ApplicationType { get; set; }
		[JsonConverter(typeof(ApplicationMatchTargetsConverter))]
		public ApplicationMatchTargets? ApplicationMatchTarget { get; set; }
	}
}
