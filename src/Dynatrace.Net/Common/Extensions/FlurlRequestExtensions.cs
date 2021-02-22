using System;
using System.Collections.Generic;
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
        private static async Task<string> GetAccessTokenAsync(string url, string userName, string password)
        {
            var result = await url
				.WithHeader("Accept", "application/json")
				.PostUrlEncodedAsync(new List<KeyValuePair<string, string>>
				{
					new KeyValuePair<string, string>("grant_type", "password"),
					new KeyValuePair<string, string>("username", userName),
					new KeyValuePair<string, string>("password", password),
					new KeyValuePair<string, string>("client_id", "admin-cli")
				})
				.ReceiveJson().ConfigureAwait(false);

            string accessToken = result
                .access_token.ToString();

            return accessToken;
        }

        private static string GetAccessToken(string url, string userName, string password) => GetAccessTokenAsync(url, userName, password).GetAwaiter().GetResult();

        public static IFlurlRequest WithAuthentication(this IFlurlRequest request, Func<string> getToken, string url, string userName, string password)
        {
            if (getToken != null)
            {
                string token = getToken();
                return request.WithOAuthBearerToken(token);
            }

            return request.WithOAuthBearerToken(GetAccessToken(url, userName, password));
        }

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
    }
}
