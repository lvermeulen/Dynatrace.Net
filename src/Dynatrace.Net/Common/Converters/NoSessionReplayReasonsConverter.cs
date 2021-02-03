using System.Collections.Generic;
using Dynatrace.Net.Environment.UserSessions.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class NoSessionReplayReasonsConverter : JsonEnumConverter<NoSessionReplayReasons>
	{
		private static readonly Dictionary<NoSessionReplayReasons, string> s_pairs = new Dictionary<NoSessionReplayReasons, string>
		{
			[NoSessionReplayReasons.KilledError] = "KILLED_ERROR",
			[NoSessionReplayReasons.KilledMinJsAgentVersion] = "KILLED_MIN_JS_AGENT_VERSION",
			[NoSessionReplayReasons.KilledNoLicense] = "KILLED_NO_LICENSE",
			[NoSessionReplayReasons.KilledWrongContentType] = "KILLED_WRONG_CONTENT_TYPE",
			[NoSessionReplayReasons.ModuleAbsentInFeatureHash] = "MODULE_ABSENT_IN_FEATURE_HASH",
			[NoSessionReplayReasons.NoActivity] = "NO_ACTIVITY",
			[NoSessionReplayReasons.OptedOutSession] = "OPTED_OUT_SESSION",
			[NoSessionReplayReasons.OptInMode] = "OPT_IN_MODE",
			[NoSessionReplayReasons.RobotDetected] = "ROBOT_DETECTED",
			[NoSessionReplayReasons.SampledOut] = "SAMPLED_OUT",
			[NoSessionReplayReasons.UnableToLoadWorker] = "UNABLE_TO_LOAD_WORKER",
			[NoSessionReplayReasons.UnhandledException] = "UNHANDLED_EXCEPTION",
			[NoSessionReplayReasons.Unknown] = "UNKNOWN",
			[NoSessionReplayReasons.UnsupportedBrowser] = "UNSUPPORTED_BROWSER",
			[NoSessionReplayReasons.ViewExcluded] = "VIEW_EXCLUDED"
		};

		protected override Dictionary<NoSessionReplayReasons, string> Pairs => s_pairs;

		protected override string EntityString => "reason for no session replay";
	}
}
