namespace Dynatrace.Net.Environment.UserSessions.Models
{
	public enum NoSessionReplayReasons
	{
		KilledError,
		KilledMinJsAgentVersion,
		KilledNoLicense,
		KilledWrongContentType,
		ModuleAbsentInFeatureHash,
		NoActivity,
		OptedOutSession,
		OptInMode,
		RobotDetected,
		SampledOut,
		UnableToLoadWorker,
		UnhandledException,
		Unknown,
		UnsupportedBrowser,
		ViewExcluded
	}
}
