using System.Collections.Generic;

namespace Dynatrace.Net.Environment.ProblemsV2.Models
{
	public class EvidenceDetails
	{
		public int? TotalCount { get; set; }
		public IEnumerable<Evidence> Details { get; set; }
	}
}
