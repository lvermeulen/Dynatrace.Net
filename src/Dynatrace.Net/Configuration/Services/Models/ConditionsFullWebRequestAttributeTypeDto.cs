using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ConditionsFullWebRequestAttributeTypeDto
	{
		[JsonConverter(typeof(AttributeTypesConverter))]
		public AttributeTypes? AttributeType { get; set; }
		public IEnumerable<CompareOperation> CompareOperations { get; set; }
	}
}
