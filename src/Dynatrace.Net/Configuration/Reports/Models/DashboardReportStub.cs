using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Reports.Models
{
	public class DashboardReportStub
	{
		public string Id { get; set; }
		[JsonConverter(typeof(ReportTypesConverter))]
		public ReportTypes? Type { get; set; }
		public string DashboardId { get; set; }
	}
}
