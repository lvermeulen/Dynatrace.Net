namespace Dynatrace.Net.Environment.UserSessions.Models
{
	public class UserSessionSyntheticEvent
	{
		public string Name { get; set; }
		public string SyntheticEventId { get; set; }
		public int? SequenceNumber { get; set; }
		public int? Timestamp { get; set; }
		public string Type { get; set; }
		public int? ErrorCode { get; set; }
		public string ErrorName { get; set; }
	}
}
