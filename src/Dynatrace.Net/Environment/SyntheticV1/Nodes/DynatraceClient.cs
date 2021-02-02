using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Environment.SyntheticV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetSyntheticNodesV1Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/synthetic/nodes");
		}

		public async Task<NodesObject> GetSyntheticNodesV1Async(CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticNodesV1Url()
				.GetJsonAsync<NodesObject>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Node> GetSyntheticNodeV1Async(string nodeId, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticNodesV1Url()
				.AppendPathSegment(nodeId)
				.GetJsonAsync<Node>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}