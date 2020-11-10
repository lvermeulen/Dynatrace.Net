using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MethodVisibilitiesConverter : JsonEnumConverter<MethodVisibilities>
	{
		private static readonly Dictionary<MethodVisibilities, string> s_pairs = new Dictionary<MethodVisibilities, string>
		{
			[MethodVisibilities.Internal] = "INTERNAL",
			[MethodVisibilities.PackageProtected] = "PACKAGE_PROTECTED",
			[MethodVisibilities.Private] = "PRIVATE",
			[MethodVisibilities.Protected] = "PROTECTED",
			[MethodVisibilities.Public] = "PUBLIC"
		};

		protected override Dictionary<MethodVisibilities, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "method visibility";
	}
}
