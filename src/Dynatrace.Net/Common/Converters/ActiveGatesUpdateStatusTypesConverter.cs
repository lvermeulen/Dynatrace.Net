using System.Collections.Generic;
using Dynatrace.Net.Environment.ActiveGates.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ActiveGatesUpdateStatusTypesConverter : JsonEnumConverter<ActiveGatesUpdateStatusTypes>
	{
		private static readonly Dictionary<ActiveGatesUpdateStatusTypes, string> s_pairs = new Dictionary<ActiveGatesUpdateStatusTypes, string>
		{
			[ActiveGatesUpdateStatusTypes.Incompatible] = "INCOMPATIBLE",
			[ActiveGatesUpdateStatusTypes.Outdated] = "OUTDATED",
			[ActiveGatesUpdateStatusTypes.Suppressed] = "SUPPRESSED",
			[ActiveGatesUpdateStatusTypes.Unknown] = "UNKNOWN",
			[ActiveGatesUpdateStatusTypes.Up2Date] = "UP2DATE",
			[ActiveGatesUpdateStatusTypes.UpdateInProgress] = "UPDATE_IN_PROGRESS",
			[ActiveGatesUpdateStatusTypes.UpdatePending] = "UPDATE_PENDING",
			[ActiveGatesUpdateStatusTypes.UpdateProblem] = "UPDATE_PROBLEM"
		};

		protected override Dictionary<ActiveGatesUpdateStatusTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "update status";
	}
}
