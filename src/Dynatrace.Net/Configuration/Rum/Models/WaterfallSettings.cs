namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class WaterfallSettings
	{
		public int? UncompressedResourcesThreshold { get; set; }
		public int? ResourcesThreshold { get; set; }
		public int? ResourceBrowserCachingThreshold { get; set; }
		public int? SlowFirstPartyResourcesThreshold { get; set; }
		public int? SlowThirdPartyResourcesThreshold { get; set; }
		public int? SlowCdnResourcesThreshold { get; set; }
		public int? SpeedIndexVisuallyCompleteRatioThreshold { get; set; }
	}
}