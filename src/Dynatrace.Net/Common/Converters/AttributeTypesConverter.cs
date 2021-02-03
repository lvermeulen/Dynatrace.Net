using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AttributeTypesConverter : JsonEnumConverter<AttributeTypes>
	{
		private static readonly Dictionary<AttributeTypes, string> s_pairs = new Dictionary<AttributeTypes, string>
		{
			[AttributeTypes.ApplicationId] = "APPLICATION_ID",
			[AttributeTypes.ContextRoot] = "CONTEXT_ROOT",
			[AttributeTypes.PgTag] = "PG_TAG",
			[AttributeTypes.ServerName] = "SERVER_NAME",
			[AttributeTypes.UrlHostName] = "URL_HOST_NAME",
			[AttributeTypes.UrlPath] = "URL_PATH"
		};

		protected override Dictionary<AttributeTypes, string> Pairs => s_pairs;

		protected override string EntityString => "attribute type";
	}
}
