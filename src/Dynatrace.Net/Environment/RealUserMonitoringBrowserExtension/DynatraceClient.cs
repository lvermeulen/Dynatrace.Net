using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Environment.RealUserMonitoringBrowserExtension.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetRealUserMonitoringBrowserExtensionUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/browserextension/config");
		}

		public async Task<RealUserMonitoringBrowserExtensionResult> GetRealUserMonitoringBrowserExtensionsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetRealUserMonitoringBrowserExtensionUrl()
				.GetJsonAsync<RealUserMonitoringBrowserExtensionResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}