using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class IconTypesConverter : JsonEnumConverter<IconTypes>
	{
		private static readonly Dictionary<IconTypes, string> s_pairs = new Dictionary<IconTypes, string>
		{
			[IconTypes.AmazonEcho] = "AMAZON_ECHO",
			[IconTypes.Desktop] = "DESKTOP",
			[IconTypes.Embedded] = "EMBEDDED",
			[IconTypes.Iot] = "IOT",
			[IconTypes.MicrosoftHololens] = "MICROSOFT_HOLOLENS",
			[IconTypes.Ufo] = "UFO",
			[IconTypes.Users] = "USERS"
		};

		protected override Dictionary<IconTypes, string> Pairs => s_pairs;

		protected override string EntityString => "icon type";
	}
}
