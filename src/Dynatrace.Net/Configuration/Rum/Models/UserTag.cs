namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class UserTag
	{
		public int? UniqueId { get; set; }
		public int? MetadataId { get; set; }
		public string CleanupRule { get; set; }
		public string ServerSideRequestAttribute { get; set; }
		public bool? IgnoreCase { get; set; }
	}
}
