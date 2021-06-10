using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.CustomTags.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetCustomTagsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v2/tags");
		}

		public async Task<CustomEntityTags> GetTagsAsync(EntitySelector entitySelector, Timeframe from = null, Timeframe to = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>();
			if (entitySelector is not null)
			{
				queryParamValues.Add(nameof(entitySelector), entitySelector.ToString());
			}

			if (from is not null)
			{
				queryParamValues.Add(nameof(from), from.ToString());
			}

			if (to is not null)
			{
				queryParamValues.Add(nameof(to), to.ToString());
			}

			var response = await GetCustomTagsUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonIfNotEmptyAsync(new CustomEntityTags(), cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<AddedEntityTags> AssignTagsAsync(EntitySelector entitySelector, AddEntityTags body, CancellationToken cancellationToken = default)
		{
			var response = await GetCustomTagsUrl()
				.SetQueryParam(nameof(entitySelector), entitySelector.ToString())
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<AddedEntityTags>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<DeletedEntityTags> DeleteTagAsync(EntitySelector entitySelector, string key, string value = null, bool? deleteAllWithKey = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(entitySelector)] = entitySelector.ToString(),
				[nameof(key)] = key,
				[nameof(value)] = value,
				[nameof(deleteAllWithKey)] = deleteAllWithKey
			};

			var response = await GetCustomTagsUrl()
				.SetQueryParams(queryParamValues)
				.DeleteAsync(cancellationToken)
				.ReceiveJsonWithErrorChecking<DeletedEntityTags>()
				.ConfigureAwait(false);

			return response;
		}
	}
}
