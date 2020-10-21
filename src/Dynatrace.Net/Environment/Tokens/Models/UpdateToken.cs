using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.Tokens.Models
{
	public class UpdateToken
	{
		public bool? Revoked { get; set; }
		public string Name { get; set; }
		[JsonConverter(typeof(PermissionsConverter))]
		public IEnumerable<Permissions> Scopes { get; set; }
	}
}
