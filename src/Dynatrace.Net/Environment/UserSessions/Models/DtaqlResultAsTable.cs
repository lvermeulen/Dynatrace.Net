using System.Collections.Generic;

namespace Dynatrace.Net.Environment.UserSessions.Models
{
	public class DtaqlResultAsTable
	{
		public int? ExtrapolationLevel { get; set; }
		public IEnumerable<string> AdditionalColumnNames { get; set; }
		public IEnumerable<object> AdditionalValues { get; set; }
		public IEnumerable<string> Explanations { get; set; }
		public IEnumerable<string> ColumnNames { get; set; }
		public IEnumerable<object> Values { get; set; }
	}
}
