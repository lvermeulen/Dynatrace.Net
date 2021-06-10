using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.Events.Models;
using Newtonsoft.Json;
using Xunit;

namespace Dynatrace.Net.Tests.Common
{
	public class MeTypesConverterShould
	{
		private readonly MeTypesConverter _converter = new MeTypesConverter();

		[Fact]
		public void Convert()
		{
			var meTypes = MeTypes.Application;
			string s = _converter.ConvertToString(meTypes);
			Assert.Equal("APPLICATION", s);
		}

		[Fact]
		public void ConvertEnumerable()
		{
			var tagMatchRule = new TagMatchRule { MeTypes = new [] { MeTypes.Application } };
			string s = JsonConvert.SerializeObject(tagMatchRule);
			Assert.Contains("\"MeTypes\":[\"APPLICATION\"]", s);
		}
	}
}
