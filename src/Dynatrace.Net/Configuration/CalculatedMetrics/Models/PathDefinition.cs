using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class PathDefinition
	{
		public string Definition { get; set; }
		[JsonConverter(typeof(PathDefinitionTypesConverter))]
		public PathDefinitionTypes? Type { get; set; }
	}
}
