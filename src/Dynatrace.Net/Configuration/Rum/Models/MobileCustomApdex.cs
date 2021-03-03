namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class MobileCustomApdex
	{
		public int? ToleratedThreshold { get; set; }
		public int? FrustratingThreshold { get; set; }
		public bool? FrustratedOnError { get; set; }
	}
}
