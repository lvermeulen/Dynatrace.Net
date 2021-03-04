namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class GlobalEventCaptureSettings
	{
		public bool? MouseUp { get; set; }
		public bool? MouseDown { get; set; }
		public bool? Click { get; set; }
		public bool? DoubleClick { get; set; }
		public bool? KeyUp { get; set; }
		public bool? KeyDown { get; set; }
		public bool? Scroll { get; set; }
		public string AdditionalEventCapturedAsUserInput { get; set; }
	}
}
