using System.Collections.Generic;

namespace Dynatrace.Net.Environment.UserSessions.Models
{
	public class DtaqlResultAsTree
	{
		public int? ExtrapolationLevel { get; set; }
		public IEnumerable<string> AdditionalColumnNames { get; set; }
		public IEnumerable<object> AdditionalValues { get; set; }
		public IEnumerable<string> Explanations { get; set; }
		public IEnumerable<string> BranchNames { get; set; }
		public IEnumerable<string> LeafNames { get; set; }
		public object Values { get; set; }
	}
}
