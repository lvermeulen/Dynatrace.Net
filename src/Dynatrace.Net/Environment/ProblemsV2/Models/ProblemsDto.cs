using System.Collections.Generic;

namespace Dynatrace.Net.Environment.ProblemsV2.Models
{
	public class ProblemsDto
	{
		public int? TotalCount { get; set; }
		public int? PageSize { get; set; }
		public string NextPageKey { get; set; }
		public IEnumerable<Problem> Problems { get; set; }
	}
}
