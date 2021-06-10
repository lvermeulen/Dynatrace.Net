using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetTagsAsync()
		{
			var result = await _client.GetTagsAsync(new EntitySelector { DynatraceEntityId = new [] { "CUSTOM_APPLICATION-E1975E34652E4AD4" } }).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
