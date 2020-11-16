using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class ExtensionConfigurationList
	{
		public IEnumerable<EntityShortRepresentation> ConfigurationsList { get; set; }
		public int? TotalResults { get; set; }
		public string NextPageKey { get; set; }
	}
}
