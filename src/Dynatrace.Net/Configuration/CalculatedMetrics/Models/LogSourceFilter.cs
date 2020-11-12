using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class LogSourceFilter
	{
		public IEnumerable<PathDefinition> PathDefinitions { get; set; }
		public IEnumerable<string> SourceEntities { get; set; }
		public IEnumerable<string> HostFilters { get; set; }
		[JsonConverter(typeof(OsTypesConverter))]
		public IEnumerable<OsTypes> OsTypes { get; set; }
	}
}
