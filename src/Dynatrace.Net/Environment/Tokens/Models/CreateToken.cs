using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.Tokens.Models
{
	public class CreateToken
	{
		public string Name { get; set; }
		public IEnumerable<Permissions> Scopes { get; set; }
		public Duration ExpiresIn { get; set; }

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}
	}
}
