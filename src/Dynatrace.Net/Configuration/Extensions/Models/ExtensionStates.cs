namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public enum ExtensionStates
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
