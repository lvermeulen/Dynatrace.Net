namespace Dynatrace.Net.Environment.OneAgentOnAHost.Models
{
	public class ModuleInstance
	{
		public string InstanceName { get; set; }
		public string ModuleVersion { get; set; }
		public bool? FaultyVersion { get; set; }
		public bool? Active { get; set; }
	}
}
