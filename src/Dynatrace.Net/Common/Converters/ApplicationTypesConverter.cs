using System.Collections.Generic;
using Dynatrace.Net.Environment.UserSessions.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ApplicationTypesConverter : JsonEnumConverter<ApplicationTypes>
	{
		private static readonly Dictionary<ApplicationTypes, string> s_pairs = new Dictionary<ApplicationTypes, string>
		{
			[ApplicationTypes.AmpApplication] = "AMP_APPLICATION",
			[ApplicationTypes.CustomApplication] = "CUSTOM_APPLICATION",
			[ApplicationTypes.MobileApplication] = "MOBILE_APPLICATION",
			[ApplicationTypes.WebApplication] = "WEB_APPLICATION"
		};
		
		protected override Dictionary<ApplicationTypes, string> Pairs => s_pairs;

		protected override string EntityString => "application type";
	}
}
