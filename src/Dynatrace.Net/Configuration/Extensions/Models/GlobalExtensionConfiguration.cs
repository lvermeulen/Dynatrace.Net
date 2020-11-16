namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class GlobalExtensionConfiguration
	{
		public string ExtensionId { get; set; }
		public bool? Enabled { get; set; }
		public bool? InfraOnlyEnabled { get; set; }
		public object Properties { get; set; }
	}
}
