using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.MaintenanceWindows.Models
{
	public class MaintenanceWindow
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		[JsonConverter(typeof(MaintenanceWindowTypesConverter))]
		public MaintenanceWindowTypes? Type { get; set; }
		[JsonConverter(typeof(MaintenanceWindowSuppressionsConverter))]
		public MaintenanceWindowSuppressions? Suppression { get; set; }
		public Scope Scope { get; set; }
		public Schedule Schedule { get; set; }
	}
}
