namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class Apdex
	{
		public decimal? Threshold { get; set; }
		public decimal? ToleratedThreshold { get; set; }
		public decimal? FrustratingThreshold { get; set; }
		public decimal? ToleratedFallbackThreshold { get; set; }
		public decimal? FrustratingFallbackThreshold { get; set; }
	}
}
