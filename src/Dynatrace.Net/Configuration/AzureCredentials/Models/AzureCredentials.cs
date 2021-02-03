using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.AzureCredentials.Models
{
	public class AzureCredentials
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string Label { get; set; }
		public string AppId { get; set; }
		public string DirectoryId { get; set; }
		public string Key { get; set; }
		public bool? Active { get; set; }
		public bool? AutoTagging { get; set; }
		public bool? MonitorOnlyTaggedEntities { get; set; }
		public IEnumerable<CloudTag> MonitorOnlyTagPairs { get; set; }
		public IEnumerable<AzureSupportingService> SupportingServices { get; set; }
	}
}
