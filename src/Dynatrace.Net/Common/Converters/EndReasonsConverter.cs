using System.Collections.Generic;
using Dynatrace.Net.Environment.UserSessions.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class EndReasonsConverter : JsonEnumConverter<EndReasons>
	{
		private static readonly Dictionary<EndReasons, string> s_pairs = new Dictionary<EndReasons, string>
		{
			[EndReasons.DurationLimit] = "DURATION_LIMIT",
			[EndReasons.EndEvent] = "END_EVENT",
			[EndReasons.ExtendedTimeout] = "EXTENDED_TIMEOUT",
			[EndReasons.TestFailed] = "TEST_FAILED",
			[EndReasons.Timeout] = "TIMEOUT",
			[EndReasons.UserActionLimit] = "USER_ACTION_LIMIT"
		};

		protected override Dictionary<EndReasons, string> Pairs => s_pairs;

		protected override string EntityString => "end reason";
	}
}
