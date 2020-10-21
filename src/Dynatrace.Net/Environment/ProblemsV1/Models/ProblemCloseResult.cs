namespace Dynatrace.Net.Environment.ProblemsV1.Models
{
	public class ProblemCloseResult
	{
		public string ProblemId { get; set; }
		public ProblemComment Comment { get; set; }
		public int? CloseTimestamp { get; set; }
		public bool? Closing { get; set; }
	}
}
