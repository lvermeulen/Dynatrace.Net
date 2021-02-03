using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class DataSourceSourceTypesConverter : JsonEnumConverter<DataSourceSourceTypes>
	{
		private static readonly Dictionary<DataSourceSourceTypes, string> s_pairs = new Dictionary<DataSourceSourceTypes, string>
		{
			[DataSourceSourceTypes.CicsSdk] = "CICS_SDK",
			[DataSourceSourceTypes.ClientIp] = "CLIENT_IP",
			[DataSourceSourceTypes.CustomAttribute] = "CUSTOM_ATTRIBUTE",
			[DataSourceSourceTypes.IibLabel] = "IIB_LABEL",
			[DataSourceSourceTypes.IibNode] = "IIB_NODE",
			[DataSourceSourceTypes.MethodParam] = "METHOD_PARAM",
			[DataSourceSourceTypes.PostParameter] = "POST_PARAMETER",
			[DataSourceSourceTypes.QueryParameter] = "QUERY_PARAMETER",
			[DataSourceSourceTypes.RequestHeader] = "REQUEST_HEADER",
			[DataSourceSourceTypes.ResponseHeader] = "RESPONSE_HEADER",
			[DataSourceSourceTypes.SessionAttribute] = "SESSION_ATTRIBUTE",
			[DataSourceSourceTypes.Uri] = "URI",
			[DataSourceSourceTypes.UriPath] = "URI_PATH"
		};

		protected override Dictionary<DataSourceSourceTypes, string> Pairs => s_pairs;

		protected override string EntityString => "source type";
	}
}
