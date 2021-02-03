using System.Collections.Generic;
using Dynatrace.Net.Configuration.AwsCredentials.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AwsAuthenticationDataTypesConverter : JsonEnumConverter<AwsAuthenticationDataTypes>
	{
		private static readonly Dictionary<AwsAuthenticationDataTypes, string> s_pairs = new Dictionary<AwsAuthenticationDataTypes, string>
		{
			[AwsAuthenticationDataTypes.Keys] = "KEYS",
			[AwsAuthenticationDataTypes.Role] = "ROLE"
		};

		protected override Dictionary<AwsAuthenticationDataTypes, string> Pairs => s_pairs;

		protected override string EntityString => "AWS authentication data type";
	}
}
