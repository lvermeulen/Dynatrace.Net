using System.Collections.Generic;
using Dynatrace.Net.Configuration.MobileSymbolication.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MobileOsTypesConverter : JsonEnumConverter<MobileOsTypes>
	{
		private static readonly Dictionary<MobileOsTypes, string> s_pairs = new Dictionary<MobileOsTypes, string>
		{
			[MobileOsTypes.Android] = "ANDROID",
			[MobileOsTypes.Ios] = "IOS",
			[MobileOsTypes.Tvos] = "TVOS"
		};

		protected override Dictionary<MobileOsTypes, string> Pairs => s_pairs;

		protected override string EntityString => "mobile OS type";
	}
}
