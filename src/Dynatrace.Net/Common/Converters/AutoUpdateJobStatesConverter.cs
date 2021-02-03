using System.Collections.Generic;
using Dynatrace.Net.Environment.ActiveGates.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AutoUpdateJobStatesConverter : JsonEnumConverter<AutoUpdateJobStates>
	{
		private static readonly Dictionary<AutoUpdateJobStates, string> s_pairs = new Dictionary<AutoUpdateJobStates, string>
		{
			[AutoUpdateJobStates.Failed] = "FAILED",
			[AutoUpdateJobStates.InProgress] = "IN_PROGRESS",
			[AutoUpdateJobStates.Pending] = "PENDING",
			[AutoUpdateJobStates.Rollback] = "ROLLBACK",
			[AutoUpdateJobStates.Skipped] = "SKIPPED",
			[AutoUpdateJobStates.Succeed] = "SUCCEED"
		};

		protected override Dictionary<AutoUpdateJobStates, string> Pairs => s_pairs;

		protected override string EntityString => "job state";
	}
}
