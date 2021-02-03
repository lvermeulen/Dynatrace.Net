using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class RumMetricsConverter : JsonEnumConverter<RumMetrics>
	{
		private static readonly Dictionary<RumMetrics, string> s_pairs = new Dictionary<RumMetrics, string>
		{
			[RumMetrics.Apdex] = "Apdex",
			[RumMetrics.ApplicationCache] = "ApplicationCache",
			[RumMetrics.Callback] = "Callback",
			[RumMetrics.DnsLookup] = "DNSLookup",
			[RumMetrics.DomComplete] = "DOMComplete",
			[RumMetrics.DomContentLoaded] = "DOMContentLoaded",
			[RumMetrics.DomInteractive] = "DOMInteractive",
			[RumMetrics.DoubleProperty] = "DoubleProperty",
			[RumMetrics.ErrorCount] = "ErrorCount",
			[RumMetrics.FirstContentfulPaint] = "FirstContentfulPaint",
			[RumMetrics.FirstInputDelay] = "FirstInputDelay",
			[RumMetrics.FirstInputStart] = "FirstInputStart",
			[RumMetrics.FirstPaint] = "FirstPaint",
			[RumMetrics.HtmlDownloaded] = "HTMLDownloaded",
			[RumMetrics.LargestContentfulPaint] = "LargestContentfulPaint",
			[RumMetrics.LoadEventEnd] = "LoadEventEnd",
			[RumMetrics.LoadEventStart] = "LoadEventStart",
			[RumMetrics.LongProperty] = "LongProperty",
			[RumMetrics.NavigationStart] = "NavigationStart",
			[RumMetrics.OnDomContentLoaded] = "OnDOMContentLoaded",
			[RumMetrics.OnLoad] = "OnLoad",
			[RumMetrics.Processing] = "Processing",
			[RumMetrics.RedirectTime] = "RedirectTime",
			[RumMetrics.Request] = "Request",
			[RumMetrics.RequestStart] = "RequestStart",
			[RumMetrics.Response] = "Response",
			[RumMetrics.SecureConnect] = "SecureConnect",
			[RumMetrics.SpeedIndex] = "SpeedIndex",
			[RumMetrics.TcpConnect] = "TCPConnect",
			[RumMetrics.TimeToFirstByte] = "TimeToFirstByte",
			[RumMetrics.UserActionDuration] = "UserActionDuration",
			[RumMetrics.VisuallyComplete] = "VisuallyComplete"
		};

		protected override Dictionary<RumMetrics, string> Pairs => s_pairs;
		protected override string EntityString => "metric";
	}
}
