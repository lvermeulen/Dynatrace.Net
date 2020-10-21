using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.Tokens.Models
{
	public class TokenMetadata
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string UserId { get; set; }
		public bool? Revoked { get; set; }
		public int? Created { get; set; }
		public int? Expires { get; set; }
		public int? LastUse { get; set; }
		[JsonConverter(typeof(PermissionsConverter))]
		public IEnumerable<Permissions> Scopes { get; set; }
	}
}
