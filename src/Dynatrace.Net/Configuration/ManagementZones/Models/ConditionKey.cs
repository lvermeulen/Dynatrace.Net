using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.ManagementZones.Models
{
	public class ConditionKey
	{
		[JsonConverter(typeof(ConditionKeyAttributeTypesConverter))]
		public ConditionKeyAttributeTypes? Attribute { get; set; }
		[JsonConverter(typeof(ConditionKeyTypesConverter))]
		public ConditionKeyTypes? Type { get; set; }
	}
}
