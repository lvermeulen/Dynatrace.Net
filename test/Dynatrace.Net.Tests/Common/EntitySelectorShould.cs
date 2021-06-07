using Dynatrace.Net.Common.Models;
using Xunit;

namespace Dynatrace.Net.Tests.Common
{
	public class EntitySelectorShould
	{
		[Fact]
		public void ConvertToString()
		{
			var entitySelector = new EntitySelector { HealthState = HealthStates.Unhealthy };
			string s = entitySelector.ToString();
			Assert.NotNull(s);
			Assert.Equal("healthState(\"UNHEALTHY\")", s);
		}
	}
}
