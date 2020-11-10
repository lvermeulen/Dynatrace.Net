using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ConditionsFullWebServiceAttributeTypeDto
	{
		[JsonConverter(typeof(AttributeTypesConverter))]
		public AttributeTypes? AttributeType { get; set; }
		[JsonConverter(typeof(CompareOperationsConverter))]
		public IEnumerable<CompareOperations> CompareOperations { get; set; }
	}
}
