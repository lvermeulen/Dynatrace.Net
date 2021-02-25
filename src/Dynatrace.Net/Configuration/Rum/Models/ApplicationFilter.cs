using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Configuration.Services.Models;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ApplicationFilter
	{
		public string Pattern { get; set; }
		[JsonConverter(typeof(ValueConditionOperatorsConverter))]  
		public ValueConditionOperators? ApplicationMatchType { get; set; }
		[JsonConverter(typeof(ApplicationMatchTargetsConverter))]  
		public ApplicationMatchTargets? ApplicationMatchTarget { get; set; }
	}
}
