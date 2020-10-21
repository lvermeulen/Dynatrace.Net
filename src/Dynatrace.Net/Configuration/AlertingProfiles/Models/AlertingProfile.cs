using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.AlertingProfiles.Models
{
	public class AlertingProfile
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string DisplayName { get; set; }
		public IEnumerable<AlertingProfileSeverityRule> Rules { get; set; }
		public string MzId { get; set; }
		public IEnumerable<AlertingEventTypeFilter> EventTypeFilters { get; set; }
	}
}
