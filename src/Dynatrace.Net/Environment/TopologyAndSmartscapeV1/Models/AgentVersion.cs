namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class AgentVersion
	{
		public int? Major { get; set; }
		public int? Minor { get; set; }
		public int? Revision { get; set; }
		public string Timestamp { get; set; }
		public string SourceRevision { get; set; }
	}
}
