using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetTopologyCustomDeviceUrl(string customDeviceId)
		{
			return GetBaseUrl()
				.AppendPathSegment($"v1/entity/infrastructure/custom/{customDeviceId}");
		}

		public async Task<CustomDevicePushResult> CreateCustomDeviceAsync(string customDeviceId, CustomDevicePushMessage body, CancellationToken cancellationToken = default)
		{
			var result = await GetTopologyCustomDeviceUrl(customDeviceId)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<CustomDevicePushResult>()
				.ConfigureAwait(false);

			return result;
		}
	}
}
