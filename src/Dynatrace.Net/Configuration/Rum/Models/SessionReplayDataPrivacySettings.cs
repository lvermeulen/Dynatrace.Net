using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class SessionReplayDataPrivacySettings
	{
		public bool? OptInModeEnabled { get; set; }
		public IEnumerable<string> UrlExclusionRules { get; set; }
		public SessionReplayContentMaskingSettings ContentMaskingSettings { get; set; }
	}
}
