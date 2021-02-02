using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class TagWithSourceInfo
	{
		[JsonConverter(typeof(TagWithSourceInfoSourcesConverter))]
		public TagWithSourceInfoSources? Source { get; set; }
		[JsonConverter(typeof(TagInfoContextsConverter))]
		public TagInfoContexts? Context { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }
	}
}
