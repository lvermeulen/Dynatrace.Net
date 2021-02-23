namespace Dynatrace.Net.Configuration.Plugins.Models
{
	public enum PluginStates
	{
		Disabled,
		ErrorAuth,
		ErrorCommunicationFailure,
		ErrorConfig,
		ErrorTimeout,
		ErrorUnknown,
		Incompatible,
		LimitReached,
		NothingToReport,
		Ok,
		StateTypeUnknown,
		Uninitialized,
		Unsupported,
		WaitingForState
	}
}
