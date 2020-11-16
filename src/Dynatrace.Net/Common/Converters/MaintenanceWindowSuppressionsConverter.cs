using System.Collections.Generic;
using Dynatrace.Net.Configuration.MaintenanceWindows.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MaintenanceWindowSuppressionsConverter : JsonEnumConverter<MaintenanceWindowSuppressions>
	{
		private static readonly Dictionary<MaintenanceWindowSuppressions, string> s_pairs = new Dictionary<MaintenanceWindowSuppressions, string>
		{
			[MaintenanceWindowSuppressions.DetectProblemsAndAlert] = "DETECT_PROBLEMS_AND_ALERT",
			[MaintenanceWindowSuppressions.DetectProblemsDontAlert] = "DETECT_PROBLEMS_DONT_ALERT",
			[MaintenanceWindowSuppressions.DontDetectProblems] = "DONT_DETECT_PROBLEMS"
		};

		protected override Dictionary<MaintenanceWindowSuppressions, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "maintenance window suppression";
	}
}
