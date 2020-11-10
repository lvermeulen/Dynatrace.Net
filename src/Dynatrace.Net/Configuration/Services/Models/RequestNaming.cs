using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class RequestNaming
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string Order { get; set; }
		public bool? Enabled { get; set; }
		public string NamingPattern { get; set; }
		public IEnumerable<string> ManagementZones { get; set; }
		public IEnumerable<Condition> Conditions { get; set; }
		public IEnumerable<Placeholder> Placeholders { get; set; }
	}
}
