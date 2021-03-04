using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class InjectionModesConverter : JsonEnumConverter<InjectionModes>
	{
		private static readonly Dictionary<InjectionModes, string> s_pairs = new Dictionary<InjectionModes, string>
		{
			[InjectionModes.CodeSnippet] = "CODE_SNIPPET",
			[InjectionModes.CodeSnippetAsync] = "CODE_SNIPPET_ASYNC",
			[InjectionModes.InlineCode] = "INLINE_CODE",
			[InjectionModes.JavascriptTag] = "JAVASCRIPT_TAG"
		};

		protected override Dictionary<InjectionModes, string> Pairs => s_pairs;

		protected override string EntityString => "injection mode";
	}
}
