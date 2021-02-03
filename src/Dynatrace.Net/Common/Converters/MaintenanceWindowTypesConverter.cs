using System.Collections.Generic;
using Dynatrace.Net.Configuration.MaintenanceWindows.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MaintenanceWindowTypesConverter : JsonEnumConverter<MaintenanceWindowTypes>
	{
		private static readonly Dictionary<MaintenanceWindowTypes, string> s_pairs = new Dictionary<MaintenanceWindowTypes, string>
		{
			[MaintenanceWindowTypes.Planned] = "PLANNED",
			[MaintenanceWindowTypes.Unplanned] = "UNPLANNED"
		};

		protected override Dictionary<MaintenanceWindowTypes, string> Pairs => s_pairs;

		protected override string EntityString => "maintenance window type";
	}
}
