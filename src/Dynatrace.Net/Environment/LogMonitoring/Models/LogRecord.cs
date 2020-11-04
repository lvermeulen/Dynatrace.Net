namespace Dynatrace.Net.Environment.LogMonitoring.Models
{
	public class LogRecord
	{
		public int? Timestamp { get; set; }
		public string LogLevel { get; set; }
		public string HostId { get; set; }
		public string Text { get; set; }
		public object CustomFields { get; set; }
	}
}
