using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UserActionDetailsMatchEntitiesConverter : JsonEnumConverter<UserActionDetailsMatchEntities>
	{
		private static readonly Dictionary<UserActionDetailsMatchEntities, string> s_pairs = new Dictionary<UserActionDetailsMatchEntities, string>
		{
			[UserActionDetailsMatchEntities.ActionName] = "ActionName",
			[UserActionDetailsMatchEntities.CssSelector] = "CssSelector",
			[UserActionDetailsMatchEntities.JavaScriptVariable] = "JavaScriptVariable",
			[UserActionDetailsMatchEntities.MetaTag] = "MetaTag",
			[UserActionDetailsMatchEntities.PagePath] = "PagePath",
			[UserActionDetailsMatchEntities.PageTitle] = "PageTitle",
			[UserActionDetailsMatchEntities.PageUrl] = "PageUrl",
			[UserActionDetailsMatchEntities.UrlAnchor] = "UrlAnchor",
			[UserActionDetailsMatchEntities.XhrUrl] = "XhrUrl"
		};

		protected override Dictionary<UserActionDetailsMatchEntities, string> Pairs => s_pairs;

		protected override string EntityString => "match entity";
	}
}
