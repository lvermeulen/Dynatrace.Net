namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ContentCapture
	{
		public ResourceTimingSettings ResourceTimingSettings { get; set; }
		public bool? JavaScriptErrors { get; set; }
		public TimeoutSettings TimeoutSettings { get; set; }
		public bool? VisuallyCompleteAndSpeedIndex { get; set; }
		public VisuallyComplete2Settings VisuallyComplete2Settings { get; set; }
	}
}
