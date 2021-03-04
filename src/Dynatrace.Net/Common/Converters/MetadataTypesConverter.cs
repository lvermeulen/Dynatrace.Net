using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetadataTypesConverter : JsonEnumConverter<MetadataTypes>
	{
		private static readonly Dictionary<MetadataTypes, string> s_pairs = new Dictionary<MetadataTypes, string>
		{
			[MetadataTypes.Cookie] = "COOKIE",
			[MetadataTypes.CssSelector] = "CSS_SELECTOR",
			[MetadataTypes.JavaScriptFunction] = "JAVA_SCRIPT_FUNCTION",
			[MetadataTypes.JavaScriptVariable] = "JAVA_SCRIPT_VARIABLE",
			[MetadataTypes.MetaTag] = "META_TAG",
			[MetadataTypes.QueryString] = "QUERY_STRING"
		};

		protected override Dictionary<MetadataTypes, string> Pairs => s_pairs;

		protected override string EntityString => "metadata type";
	}
}
