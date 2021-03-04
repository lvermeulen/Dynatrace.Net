namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class TimeoutSettings
	{
		public bool? TimedActionSupport { get; set; }
		public int? TemporaryActionLimit { get; set; }
		public int? TemporaryActionTotalTimeout { get; set; }
	}
}
