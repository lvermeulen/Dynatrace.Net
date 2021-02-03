using System.Collections.Generic;
using Dynatrace.Net.Environment.ActiveGates.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AutoUpdateJobUpdateMethodsConverter : JsonEnumConverter<AutoUpdateJobUpdateMethods>
	{
		private static readonly Dictionary<AutoUpdateJobUpdateMethods, string> s_pairs = new Dictionary<AutoUpdateJobUpdateMethods, string>
		{
			[AutoUpdateJobUpdateMethods.Automatic] = "AUTOMATIC",
			[AutoUpdateJobUpdateMethods.ManualInstallation] = "MANUAL_INSTALLATION",
			[AutoUpdateJobUpdateMethods.OnDemand] = "ON_DEMAND"
		};

		protected override Dictionary<AutoUpdateJobUpdateMethods, string> Pairs => s_pairs;

		protected override string EntityString => "update method";
	}
}
