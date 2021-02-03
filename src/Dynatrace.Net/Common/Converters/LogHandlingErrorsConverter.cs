using System.Collections.Generic;
using Dynatrace.Net.Environment.LogMonitoring.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class LogHandlingErrorsConverter : JsonEnumConverter<LogHandlingErrors>
	{
		private static readonly Dictionary<LogHandlingErrors, string> s_pairs = new Dictionary<LogHandlingErrors, string>
		{
			[LogHandlingErrors.AgentVersionNotSupportingDocker] = "AGENT_VERSION_NOT_SUPPORTING_DOCKER",
			[LogHandlingErrors.Cancelled] = "CANCELLED",
			[LogHandlingErrors.FileAccessDisabled] = "FILE_ACCESS_DISABLED",
			[LogHandlingErrors.FileNotFound] = "FILE_NOT_FOUND",
			[LogHandlingErrors.IncorrectDateFormat] = "INCORRECT_DATE_FORMAT",
			[LogHandlingErrors.IncorrectLogFile] = "INCORRECT_LOG_FILE",
			[LogHandlingErrors.InternalProcessingError] = "INTERNAL_PROCESSING_ERROR",
			[LogHandlingErrors.InvalidFilterQuery] = "INVALID_FILTER_QUERY",
			[LogHandlingErrors.InvalidSearchQuery] = "INVALID_SEARCH_QUERY",
			[LogHandlingErrors.None] = "NONE",
			[LogHandlingErrors.NoLogAgent] = "NO_LOG_AGENT",
			[LogHandlingErrors.ProcessorFileProcessingError] = "PROCESSOR_FILE_PROCESSING_ERROR",
			[LogHandlingErrors.ProcessorInternalError] = "PROCESSOR_INTERNAL_ERROR",
			[LogHandlingErrors.ProcessorInvalidParameterError] = "PROCESSOR_INVALID_PARAMETER_ERROR",
			[LogHandlingErrors.ProcessorNoLogsFileFoundError] = "PROCESSOR_NO_LOGS_FILE_FOUND_ERROR",
			[LogHandlingErrors.ProcessorStoppingInterrupted] = "PROCESSOR_STOPPING_INTERRUPTED",
			[LogHandlingErrors.ProcessorTimedOut] = "PROCESSOR_TIMED_OUT",
			[LogHandlingErrors.ProcessorUnhandledException] = "PROCESSOR_UNHANDLED_EXCEPTION",
			[LogHandlingErrors.ProcessorUnzippingError] = "PROCESSOR_UNZIPPING_ERROR",
			[LogHandlingErrors.RepackFailedToSaveLogAnalysisInStorage] = "REPACK_FAILED_TO_SAVE_LOG_ANALYSIS_IN_STORAGE",
			[LogHandlingErrors.RepackFailedToStoreAllLogAnalysis] = "REPACK_FAILED_TO_STORE_ALL_LOG_ANALYSIS",
			[LogHandlingErrors.RepackFailedToStoreLogAnalysis] = "REPACK_FAILED_TO_STORE_LOG_ANALYSIS",
			[LogHandlingErrors.SomeLogIncorrectDateFormat] = "SOME_LOG_INCORRECT_DATE_FORMAT",
			[LogHandlingErrors.Timeout] = "TIMEOUT"
		};

		protected override Dictionary<LogHandlingErrors, string> Pairs => s_pairs;

		protected override string EntityString => "log handling error";
	}
}
