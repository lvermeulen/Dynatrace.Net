using System.Collections.Generic;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class DisabledReasonsConverter : JsonEnumConverter<DisabledReasons>
	{
		private static readonly Dictionary<DisabledReasons, string> s_pairs = new Dictionary<DisabledReasons, string>
		{
			[DisabledReasons.None] = "NONE",
			[DisabledReasons.TooManyDims] = "TOO_MANY_DIMS",
			[DisabledReasons.TopxForcibleDeactivated] = "TOPX_FORCIBLE_DEACTIVATED"
		};

		protected override Dictionary<DisabledReasons, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "disabled reason";
	}
}
