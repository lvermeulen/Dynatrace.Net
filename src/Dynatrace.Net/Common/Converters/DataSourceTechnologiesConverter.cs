using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class DataSourceTechnologiesConverter : JsonEnumConverter<DataSourceTechnologies>
	{
		private static readonly Dictionary<DataSourceTechnologies, string> s_pairs = new Dictionary<DataSourceTechnologies, string>
		{
			[DataSourceTechnologies.Dotnet] = "DOTNET",
			[DataSourceTechnologies.Java] = "JAVA",
			[DataSourceTechnologies.Php] = "PHP"
		};

		protected override Dictionary<DataSourceTechnologies, string> Pairs => s_pairs;

		protected override string EntityString => "technology";
	}
}
