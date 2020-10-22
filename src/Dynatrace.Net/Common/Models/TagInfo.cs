using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Common.Models
{
	public class TagInfo
	{
		[JsonConverter(typeof(TagInfoContextsConverter))]
		public TagInfoContexts? Context { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }
	}
}
