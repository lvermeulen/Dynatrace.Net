using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ApplicationDataPrivacy
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Identifier { get; set; }
		public bool? DataCaptureOptInEnabled { get; set; }
		public bool? PersistentCookieForUserTracking { get; set; }
		[JsonConverter(typeof(DoNotTrackBehaviourTypesConverter))]
		public DoNotTrackBehaviourTypes? DoNotTrackBehaviour { get; set; }
		public SessionReplayDataPrivacySettings SessionReplayDataPrivacy { get; set; }
	}
}
