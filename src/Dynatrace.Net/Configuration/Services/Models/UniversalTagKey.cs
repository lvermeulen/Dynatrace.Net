using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class UniversalTagKey
	{
		[JsonConverter(typeof(UniversalTagContextsConverter))]
		public UniversalTagContexts? Context { get; set; }
		public string Key { get; set; }
	}
}
