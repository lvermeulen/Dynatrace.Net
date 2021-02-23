using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ResourceTypesConverter : JsonEnumConverter<ResourceTypes>
	{
		private static readonly Dictionary<ResourceTypes, string> s_pairs = new Dictionary<ResourceTypes, string>
		{
			[ResourceTypes.Css] = "CSS",
			[ResourceTypes.Image] = "IMAGE",
			[ResourceTypes.Other] = "OTHER",
			[ResourceTypes.Script] = "SCRIPT"
		};

		protected override Dictionary<ResourceTypes, string> Pairs => s_pairs;

		protected override string EntityString => "resource type";
	}
}
