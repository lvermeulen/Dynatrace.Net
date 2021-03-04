namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class SessionReplayContentMaskingSettings
	{
		public int? RecordingMaskingSettingsVersion { get; set; }
		public SessionReplayMaskingSetting RecordingMaskingSettings { get; set; }
		public SessionReplayMaskingSetting PlaybackMaskingSettings { get; set; }
	}
}
