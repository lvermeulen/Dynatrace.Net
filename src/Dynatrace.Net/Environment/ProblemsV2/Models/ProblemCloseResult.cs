namespace Dynatrace.Net.Environment.ProblemsV2.Models
{
	public class ProblemCloseResult
	{
		public bool? Closing { get; set; }
		public int? CloseTimestamp { get; set; }
		public string ProblemId { get; set; }
		public CommentDto Comment { get; set; }
	}
}
