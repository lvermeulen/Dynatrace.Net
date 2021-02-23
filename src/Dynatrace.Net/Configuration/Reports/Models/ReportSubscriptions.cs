using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Reports.Models
{
	public class ReportSubscriptions
	{
		[JsonConverter(typeof(ReportSchedulesConverter))]
		public ReportSchedules? Schedule { get; set; }
		public IEnumerable<string> Recipients { get; set; }
	}
}
