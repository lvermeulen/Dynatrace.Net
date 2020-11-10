using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class FullWebRequestRule
	{
		public string Type { get; set; }
		public ConfigurationMetadata Metadata { get; set; }
		public IEnumerable<string> ManagementZones { get; set; }
		public string Id { get; set; }
		public string Order { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool? Enabled { get; set; }
		public IEnumerable<ConditionsFullWebRequestAttributeTypeDto> Conditions { get; set; }
		public ApplicationId ApplicationId { get; set; }
		public ContextRoot ContextRoot { get; set; }
		public ServerName ServerName { get; set; }
	}
}
