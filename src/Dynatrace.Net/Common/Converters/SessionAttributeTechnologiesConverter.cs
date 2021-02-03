using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SessionAttributeTechnologiesConverter : JsonEnumConverter<SessionAttributeTechnologies>
	{
		private static readonly Dictionary<SessionAttributeTechnologies, string> s_pairs = new Dictionary<SessionAttributeTechnologies, string>
		{
			[SessionAttributeTechnologies.AspNet] = "ASP_NET",
			[SessionAttributeTechnologies.AspNetCore] = "ASP_NET_CORE",
			[SessionAttributeTechnologies.Java] = "JAVA"
		};

		protected override Dictionary<SessionAttributeTechnologies, string> Pairs => s_pairs;

		protected override string EntityString => "technology";
	}
}
