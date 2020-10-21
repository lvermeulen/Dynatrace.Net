using System.Collections.Generic;

namespace Dynatrace.Net.Environment.ProblemsV2.Models
{
	public class CommentsList
	{
		public IEnumerable<CommentDto> Comments { get; set; }
		public string NextPageKey { get; set; }
		public int? PageSize { get; set; }
		public int? TotalCount { get; set; }
	}
}
