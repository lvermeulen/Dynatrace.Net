namespace Dynatrace.Net.Configuration.Reports.Models
{
	public class DashboardReport : DashboardReportStub
	{
		public bool? Enabled { get; set; }
		public DashboardReportSubscription Subscriptions { get; set; }
	}
}
