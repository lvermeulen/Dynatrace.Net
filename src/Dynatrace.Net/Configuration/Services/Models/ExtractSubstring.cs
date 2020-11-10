using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ExtractSubstring
	{
		[JsonConverter(typeof(StringPositionsConverter))]
		public StringPositions? Position { get; set; }
		public string Delimiter { get; set; }
		public string EndDelimiter { get; set; }
	}
}
