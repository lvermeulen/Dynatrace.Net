using System.Collections.Generic;
using Dynatrace.Net.Environment.LogMonitoring.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class LogAnalysisStatusesConverter : JsonEnumConverter<LogAnalysisStatuses>
	{
		private static readonly Dictionary<LogAnalysisStatuses, string> s_pairs = new Dictionary<LogAnalysisStatuses, string>
		{
			[LogAnalysisStatuses.AgentProcessing] = "AGENT_PROCESSING",
			[LogAnalysisStatuses.Cancelled] = "CANCELLED",
			[LogAnalysisStatuses.CancelPending] = "CANCEL_PENDING",
			[LogAnalysisStatuses.Download] = "DOWNLOAD",
			[LogAnalysisStatuses.Failed] = "FAILED",
			[LogAnalysisStatuses.Processing] = "PROCESSING",
			[LogAnalysisStatuses.Ready] = "READY",
			[LogAnalysisStatuses.Transferring] = "TRANSFERRING",
			[LogAnalysisStatuses.Waiting] = "WAITING"
		};

		protected override Dictionary<LogAnalysisStatuses, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "log analysis status";
	}
}
