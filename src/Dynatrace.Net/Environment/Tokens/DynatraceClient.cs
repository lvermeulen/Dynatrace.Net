using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.Tokens.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly PermissionsConverter s_permissionsConverter = new PermissionsConverter();
		private static readonly TokenResultFormatsConverter s_tokenResultFormatsConverter = new TokenResultFormatsConverter();

		private IFlurlRequest GetTokensUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/tokens");
		}

		public async Task<StubList> GetAllTokensAsync(int? limit = null, string user = null, IEnumerable<Permissions> permissions = null,
			int? from = null, int? to = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>();
			if (limit is not null)
			{
				queryParamValues.Add(nameof(limit), limit);
			}

			if (user is not null)
			{
				queryParamValues.Add(nameof(user), user);
			}

			if (permissions is not null)
			{
				queryParamValues.Add(nameof(permissions), string.Join("&", permissions
					.Distinct()
					.Select(x => $"permissions={s_permissionsConverter.ConvertToString(x)}")));
			}

			if (from is not null)
			{
				queryParamValues.Add(nameof(from), from);
			}

			if (to is not null)
			{
				queryParamValues.Add(nameof(to), to);
			}

			var response = await GetTokensUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> AddTokenAsync(CreateToken body, TokenResultFormats? resultFormat, CancellationToken cancellationToken = default)
		{
			string response = await GetTokensUrl()
				.WithHeader("Accept", s_tokenResultFormatsConverter.ConvertToString(resultFormat ?? TokenResultFormats.ApplicationJson))
				.PostJsonAsync(body, cancellationToken)
				.ReceiveString()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<TokenMetadata> GetTokenMetadataAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetTokensUrl()
				.AppendPathSegment(id)
				.GetJsonIfNotEmptyAsync(new TokenMetadata(), cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<TokenMetadata> LookupTokenAsync(AToken body, CancellationToken cancellationToken = default)
		{
			var response = await GetTokensUrl()
				.AppendPathSegment("lookup")
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<TokenMetadata>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateTokenAsync(string id, UpdateToken body, CancellationToken cancellationToken = default)
		{
			var response = await GetTokensUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteTokenAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetTokensUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
