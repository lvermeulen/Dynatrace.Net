using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class JavaScriptInjectionRules
	{
		public bool? Enabled { get; set; }
		[JsonConverter(typeof(UrlOperatorsConverter))]
		public UrlOperators? UrlOperator { get; set; }
		public string UrlPattern { get; set; }
		[JsonConverter(typeof(RuleTypesConverter))]
		public RuleTypes? Rule { get; set; }
		public string HtmlPattern { get; set; }
	}
}
