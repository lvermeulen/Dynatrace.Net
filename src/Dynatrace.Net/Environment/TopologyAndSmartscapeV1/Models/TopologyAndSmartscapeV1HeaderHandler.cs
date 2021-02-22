using System;
using System.Net.Http.Headers;
using Dynatrace.Net.Common.Extensions;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public static class TopologyAndSmartscapeV1HeaderHandler
	{
		public static WithTopologyAndSmartscapeV1ResponseHeaders<T> HandleTopologyAndSmartscapeV1Headers<T>(HttpResponseHeaders headers, T instance)
		{
			var result = new WithTopologyAndSmartscapeV1ResponseHeaders<T>();
			string totalCountValue = headers.GetResponseHeadersFirstValue("Total-Count");
			if (totalCountValue != null)
			{
				result.TotalCount = Convert.ToInt32(totalCountValue);
			}

			result.NextPageKey = headers.GetResponseHeadersFirstValue("Next-Page-Key");
			result.PageSize = headers.GetResponseHeadersFirstValue("Page-Size");
			result.Instance = instance;

			return result;
		}
	}
}
