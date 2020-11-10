using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class UniversalTag
	{
		public UniversalTagKey TagKey { get; set; }
		public string Value { get; set; }
		public string Key { get; set; }
		[JsonConverter(typeof(UniversalTagContextsConverter))]
		public UniversalTagContexts? Context { get; set; }
	}
}
