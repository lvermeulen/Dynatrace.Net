using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.AlertingProfiles.Models
{
	public class AlertingProfileTagFilter
	{
		public string IncludeMode { get; set; }
		public IEnumerable<TagFilter> TagFilters { get; set; }
	}
}
