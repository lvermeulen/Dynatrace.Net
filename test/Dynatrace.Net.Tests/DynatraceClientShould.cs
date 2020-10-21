using System.IO;
using Microsoft.Extensions.Configuration;

namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		private readonly DynatraceClient _client;

		public DynatraceClientShould()
		{
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.Build();

			string url = configuration["url"];
			string userName = configuration["userName"];
			string password = configuration["password"];

			_client = new DynatraceClient(url, userName, password);
		}
	}
}
