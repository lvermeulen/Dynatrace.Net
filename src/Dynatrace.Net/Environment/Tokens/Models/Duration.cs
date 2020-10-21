using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.Tokens.Models
{
	public class Duration
	{
		public int Value { get; set; }
		[JsonConverter(typeof(TokenDurationsConverter))]
		public TokenDurations? Unit { get; set; }

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}
	}
}
