namespace Dynatrace.Net.Configuration.OneAgentOnAHost.Models
{
	public class HostConfig
	{
		public string Id { get; set; }
		public MonitoringConfig MonitoringConfig { get; set; }
		public HostAutoUpdateConfig AutoUpdateConfig { get; set; }
		public TechMonitoringList TechMonitoringConfigList { get; set; }
	}
}
