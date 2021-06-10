namespace Dynatrace.Net.Configuration.MobileSymbolication.Models
{
	public class SymbolFile
	{
		public string ApplicationName { get; set; }
		public int? Size { get; set; }
		public AppIdentifier AppId { get; set; }
		public long? UploadTimestamp { get; set; }
		public bool? Pinned { get; set; }
	}
}
