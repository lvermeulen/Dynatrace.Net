namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ResourceUrlCleanupRule
	{
		public string ResourceName { get; set; }
		public string RegularExpression { get; set; }
		public string ReplaceWith { get; set; }
	}
}
