using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Services.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetIbmMqTracingQueueManagerUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/service/ibmMQTracing/queueManager");
		}

		public async Task<StubList> GetAllIbmMqTracingQueueManagersAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetIbmMqTracingQueueManagerUrl()
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<QueueManager> GetIbmMqTracingQueueManagerAsync(string name, CancellationToken cancellationToken = default)
		{
			var response = await GetIbmMqTracingQueueManagerUrl()
				.AppendPathSegment(name)
				.GetJsonWithErrorCheckingAsync<QueueManager>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateIbmMqTracingQueueManagerAsync(string name, QueueManager body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetIbmMqTracingQueueManagerUrl()
				.AppendPathSegment(name)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteIbmMqTracingQueueManagerAsync(string name, CancellationToken cancellationToken = default)
		{
			var response = await GetIbmMqTracingQueueManagerUrl()
				.AppendPathSegment(name)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
