using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Services.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetIbmMqTracingQueueUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/service/ibmMQTracing/imsEntryQueue");
		}

		public async Task<StubList> GetAllIbmMqTracingQueuesAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetIbmMqTracingQueueUrl()
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<IbmMqImsEntryQueue> GetIbmMqTracingQueueAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetIbmMqTracingQueueUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<IbmMqImsEntryQueue>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> CreateIbmMqTracingQueueAsync(IbmMqImsEntryQueue body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetIbmMqTracingQueueUrl()
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> UpdateIbmMqTracingQueueAsync(string id, IbmMqImsEntryQueue body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetIbmMqTracingQueueUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteIbmMqTracingQueueAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetIbmMqTracingQueueUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
