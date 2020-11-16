using System.Collections.Generic;
using Dynatrace.Net.Environment.UserSessions.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UserTypesConverter : JsonEnumConverter<UserTypes>
	{
		private static readonly Dictionary<UserTypes, string> s_pairs = new Dictionary<UserTypes, string>
		{
			[UserTypes.RealUser] = "REAL_USER",
			[UserTypes.Robot] = "ROBOT",
			[UserTypes.Synthetic] = "SYNTHETIC"
		};

		protected override Dictionary<UserTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "user type";
	}
}
