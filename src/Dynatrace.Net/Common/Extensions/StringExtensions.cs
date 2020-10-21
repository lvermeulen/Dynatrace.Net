namespace Dynatrace.Net.Common.Extensions
{
	public static class StringExtensions
	{
		public static string ToCamelCase(this string s) => !string.IsNullOrEmpty(s) && s.Length > 1
			? char.ToLowerInvariant(s[0]) + s.Substring(1)
			: s;

		public static string WithPrefixAndParentheses(this string s, string prefixString, bool quoted = false)
		{
			if (s == null)
			{
				return null;
			}

			return quoted
				? $"{prefixString}(\"{s}\")"
				: $"{prefixString}({s})";
		}

		public static string WithQuotes(this string s) => s == null
			? null
			: $"\"{s}\"";

		public static string With(this string s) => $"+{s}";

		public static string Without(this string s) => $"-{s}";
	}
}
