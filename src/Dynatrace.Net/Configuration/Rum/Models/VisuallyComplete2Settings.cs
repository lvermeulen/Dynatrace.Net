namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class VisuallyComplete2Settings
	{
		public string ImageUrlBlacklist { get; set; }
		public string MutationBlacklist { get; set; }
		public int? MutationTimeout { get; set; }
		public int? InactivityTimeout { get; set; }
		public int? Threshold { get; set; }
	}
}
