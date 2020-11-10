using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class AliasQueue
	{
		[JsonProperty("aliasQueue")]
		public string Alias { get; set; }
		public string BaseQueue { get; set; }
		public IEnumerable<string> ClusterVisibility { get; set; }
	}
}
