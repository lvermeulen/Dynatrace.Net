using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class ExtensionStateList
	{
		public IEnumerable<ExtensionState> States { get; set; }
		public int? TotalResults { get; set; }
		public string NextPageKey { get; set; }
	}
}
