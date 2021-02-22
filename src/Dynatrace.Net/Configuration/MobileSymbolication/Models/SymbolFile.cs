namespace Dynatrace.Net.Configuration.MobileSymbolication.Models
{
	public class SymbolFile
	{
		public string ApplicationName { get; set; }
		public int? Size { get; set; }
		public AppIdentifier AppId { get; set; }
		public int? UploadTimestamp { get; set; }
		public bool? Pinned { get; set; }
	}
}
