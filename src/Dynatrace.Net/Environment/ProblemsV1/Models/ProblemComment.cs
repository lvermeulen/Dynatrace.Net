namespace Dynatrace.Net.Environment.ProblemsV1.Models
{
	public class ProblemComment
	{
		public string Id { get; set; }
		public int? CreatedAtTimestamp { get; set; }
		public string Content { get; set; }
		public string UserName { get; set; }
		public string Context { get; set; }
	}
}
