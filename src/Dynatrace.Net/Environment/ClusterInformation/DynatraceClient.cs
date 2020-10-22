using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Environment.ClusterInformation.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetClusterInformationUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1");
		}

		public async Task<string> GetClusterTimeAsync(CancellationToken cancellationToken = default)
		{
			string response = await GetClusterInformationUrl()
				.AppendPathSegment("time")
				.GetStringAsync(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ClusterVersion> GetClusterVersionAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetClusterInformationUrl()
				.AppendPathSegment("config")
				.AppendPathSegment("clusterversion")
				.GetJsonAsync<ClusterVersion>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
