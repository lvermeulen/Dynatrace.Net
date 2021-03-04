using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class NamingPlaceholderInputTypesConverter : JsonEnumConverter<NamingPlaceholderInputTypes>
	{
		private static readonly Dictionary<NamingPlaceholderInputTypes, string> s_pairs = new Dictionary<NamingPlaceholderInputTypes, string>
		{
			[NamingPlaceholderInputTypes.ElementIdentifier] = "ELEMENT_IDENTIFIER",
			[NamingPlaceholderInputTypes.InputType] = "INPUT_TYPE",
			[NamingPlaceholderInputTypes.Metadata] = "METADATA",
			[NamingPlaceholderInputTypes.PageTitle] = "PAGE_TITLE",
			[NamingPlaceholderInputTypes.PageUrl] = "PAGE_URL",
			[NamingPlaceholderInputTypes.SourceUrl] = "SOURCE_URL",
			[NamingPlaceholderInputTypes.TopXhrUrl] = "TOP_XHR_URL",
			[NamingPlaceholderInputTypes.XhrUrl] = "XHR_URL"
		};

		protected override Dictionary<NamingPlaceholderInputTypes, string> Pairs => s_pairs;

		protected override string EntityString => "input type";
	}
}
