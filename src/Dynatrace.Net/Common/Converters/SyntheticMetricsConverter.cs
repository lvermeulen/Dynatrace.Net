using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SyntheticMetricsConverter : JsonEnumConverter<SyntheticMetrics>
	{
		private static readonly Dictionary<SyntheticMetrics, string> s_pairs = new Dictionary<SyntheticMetrics, string>
		{
			[SyntheticMetrics.ApplicationCache] = "ApplicationCache",
			[SyntheticMetrics.Callback] = "Callback",
			[SyntheticMetrics.DnsLookup] = "DNSLookup",
			[SyntheticMetrics.DomComplete] = "DOMComplete",
			[SyntheticMetrics.DomContentLoaded] = "DOMContentLoaded",
			[SyntheticMetrics.DomInteractive] = "DOMInteractive",
			[SyntheticMetrics.FailedRequestResources] = "FailedRequestsResources",
			[SyntheticMetrics.FirstContentfulPaint] = "FirstContentfulPaint",
			[SyntheticMetrics.FirstInputDelay] = "FirstInputDelay",
			[SyntheticMetrics.FirstInputStart] = "FirstInputStart",
			[SyntheticMetrics.FirstPaint] = "FirstPaint",
			[SyntheticMetrics.HtmlDownloaded] = "HTMLDownloaded",
			[SyntheticMetrics.HttpErrors] = "HttpErrors",
			[SyntheticMetrics.JavaScriptErrors] = "JavaScriptErrors",
			[SyntheticMetrics.LargestContentfulPaint] = "LargestContentfulPaint",
			[SyntheticMetrics.LoadEventEnd] = "LoadEventEnd",
			[SyntheticMetrics.LoadEventStart] = "LoadEventStart",
			[SyntheticMetrics.NavigationStart] = "NavigationStart",
			[SyntheticMetrics.OnDomContentLoaded] = "OnDOMContentLoaded",
			[SyntheticMetrics.OnLoad] = "OnLoad",
			[SyntheticMetrics.Processing] = "Processing",
			[SyntheticMetrics.RedirectTime] = "RedirectTime",
			[SyntheticMetrics.Request] = "Request",
			[SyntheticMetrics.RequestStart] = "RequestStart",
			[SyntheticMetrics.ResourceCount] = "ResourceCount",
			[SyntheticMetrics.Response] = "Response",
			[SyntheticMetrics.SecureConnect] = "SecureConnect",
			[SyntheticMetrics.SpeedIndex] = "SpeedIndex",
			[SyntheticMetrics.TcpConnect] = "TCPConnect",
			[SyntheticMetrics.TimeToFirstByte] = "TimeToFirstByte",
			[SyntheticMetrics.TotalDuration] = "TotalDuration",
			[SyntheticMetrics.TransferSize] = "TransferSize",
			[SyntheticMetrics.UserActionDuration] = "UserActionDuration",
			[SyntheticMetrics.VisuallyComplete] = "VisuallyComplete"
		};

		protected override Dictionary<SyntheticMetrics, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "metric";
	}
}
