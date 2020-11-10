using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ClusterQueue
	{
		public string LocalQueue { get; set; }
		public IEnumerable<string> ClusterVisibility { get; set; }
	}
}
