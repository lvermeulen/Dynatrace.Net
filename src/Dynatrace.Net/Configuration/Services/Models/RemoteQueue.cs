using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class RemoteQueue
	{
		public string LocalQueue { get; set; }
		[JsonProperty("remoteQueue")]
		public string Remote{ get; set; }
		public string RemoteQueueManager { get; set; }
		public IEnumerable<string> ClusterVisibility { get; set; }
	}
}
