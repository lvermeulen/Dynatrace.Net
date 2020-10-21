using System.Collections.Generic;

namespace Dynatrace.Net.Environment.ProblemsV1.Models
{
	public class ProblemFeedQueryResult
	{
		public IEnumerable<Problem> Problems { get; set; }
		public object Monitored { get; set; }
	}
}
