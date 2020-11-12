using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class ColumnDefinition
	{
		public string Name { get; set; }
		[JsonConverter(typeof(ColumnDefinitionTypesConverter))]
		public ColumnDefinitionTypes? Type { get; set; }
	}
}
