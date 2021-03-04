namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class AdditionalEventHandlers
	{
		public bool? UserMouseupEventForClicks { get; set; }
		public bool? ClickEventHandler { get; set; }
		public bool? MouseupEventHandler { get; set; }
		public bool? BlurEventHandler { get; set; }
		public bool? ChangeEventHandler { get; set; }
		public bool? ToStringMethod { get; set; }
		public int? MaxDomNodesToInstrument { get; set; }
	}
}
