using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Flurl.Http;

namespace Dynatrace.Net.Common.Extensions
{
    public static class FlurlRequestExtensions
    {
        public static IFlurlRequest WithApiToken(this IFlurlRequest request, string apiToken) => request.WithHeader("Authorization", $"Api-Token {apiToken}");

        public static string GetResponseHeadersFirstValue(this HttpResponseHeaders headers, string headerName) => headers.TryGetValues(headerName, out var values)
	        ? values.FirstOrDefault()
	        : null;

        public static async Task<WithResponseHeaders<T>> GetJsonWithResponseHeadersAsync<T>(this IFlurlRequest request, Func<HttpResponseHeaders, T, WithResponseHeaders<T>> handleHeaders, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
	        var response = request.SendAsync(HttpMethod.Get, cancellationToken: cancellationToken, completionOption: completionOption);
	        var instance = await response.ReceiveJson<T>();
	        var actualResponse = await response;

			return handleHeaders?.Invoke(actualResponse.Headers, instance);
        }

        public static IFlurlRequest If(this IFlurlRequest request, bool condition, Func<IFlurlRequest, IFlurlRequest> flurlRequestAction)
        {
	        if (condition)
	        {
		        flurlRequestAction?.Invoke(request);
	        }

	        return request;
        }

        public static async Task<TResult> GetJsonIfNotEmptyAsync<TResult>(this IFlurlRequest request, TResult emptyResult = default, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
	        try
	        {
		        return await request.GetJsonAsync<TResult>(cancellationToken, completionOption);
	        }
	        catch (FlurlParsingException)
	        {
		        return emptyResult;
	        }
        }
    }
}
