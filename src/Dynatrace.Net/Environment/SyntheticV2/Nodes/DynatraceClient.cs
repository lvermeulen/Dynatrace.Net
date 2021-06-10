using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Environment.SyntheticV2.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetSyntheticNodesV2Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/synthetic/nodes");
		}

		public async Task<NodesObject> GetSyntheticNodesV2Async(CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticNodesV2Url()
				.GetJsonWithErrorCheckingAsync<NodesObject>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Node> GetSyntheticNodeV2Async(string nodeId, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticNodesV2Url()
				.AppendPathSegment(nodeId)
				.GetJsonWithErrorCheckingAsync<Node>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}