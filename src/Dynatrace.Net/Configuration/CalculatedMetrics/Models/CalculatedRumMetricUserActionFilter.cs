using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class CalculatedRumMetricUserActionFilter
	{
		public int? ActionDurationFromMilliseconds { get; set; }
		public int? ActionDurationToMilliseconds { get; set; }
		public bool? LoadAction { get; set; }
		public bool? XhrAction { get; set; }
		public bool? CustomAction { get; set; }
		public string Apdex { get; set; }
		public string Domain { get; set; }
		public string UserActionName { get; set; }
		public bool? RealUser { get; set; }
		public bool? Robot { get; set; }
		public bool? Synthetic { get; set; }
		public string BrowserFamily { get; set; }
		public string BrowserType { get; set; }
		public string BrowserVersion { get; set; }
		public bool? HasCustomErrors { get; set; }
		public bool? HasAnyError { get; set; }
		public bool? HasHttpErrors { get; set; }
		public bool? HasJavascriptErrors { get; set; }
		public string City { get; set; }
		public string Continent { get; set; }
		public string Country { get; set; }
		public string Region { get; set; }
		public string Ip { get; set; }
		public bool? IpV6Traffic { get; set; }
		public string OsFamily { get; set; }
		public string OsVersion { get; set; }
		public int? HttpErrorCode { get; set; }
		public string HttpPath { get; set; }
		public string CustomErrorType { get; set; }
		public string CustomErrorName { get; set; }
		public IEnumerable<UserActionPropertyFilter> UserActionProperties { get; set; }
		public string TargetViewName { get; set; }
	}
}
