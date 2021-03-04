namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class AdvancedJavaScriptTagSettings
	{
		public bool? SyncBeaconFirefox { get; set; }
		public bool? SyncBeaconInternetExplorer { get; set; }
		public bool? InstrumentUnsupportedAjaxFrameworks { get; set; }
		public string SpecialCharactersToEscape { get; set; }
		public int? MaxActionNameLength { get; set; }
		public int? MaxErrorsToCapture { get; set; }
		public AdditionalEventHandlers AdditionalEventHandlers { get; set; }
		public EventWrapperSettings EventWrapperSettings { get; set; }
		public GlobalEventCaptureSettings GlobalEventCaptureSettings { get; set; }
	}
}
