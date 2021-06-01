using System.Linq;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.Services.Models;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetExtensionsAsync()
		{
			var result = await _client.GetExtensionsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetExtensionAsync()
		{
			var results = await _client.GetExtensionsAsync().ConfigureAwait(false);
			var firstResult = results.Extensions.FirstOrDefault();

			var result = await _client.GetExtensionAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetExtensionInstancesAsync()
		{
			var results = await _client.GetExtensionsAsync().ConfigureAwait(false);
			var firstResult = results.Extensions.FirstOrDefault();

			var result = await _client.GetExtensionInstancesAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetExtensionInstanceAsync()
		{
			var results = await _client.GetExtensionsAsync().ConfigureAwait(false);
			var firstResult = results.Extensions.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var instances = await _client.GetExtensionInstancesAsync(firstResult?.Id).ConfigureAwait(false);
			var firstInstance = instances.ConfigurationsList.FirstOrDefault();
			if (firstInstance is null)
			{
				return;
			}

			var result = await _client.GetExtensionInstanceAsync(firstResult?.Id, firstInstance?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetExtensionGlobalConfigurationAsync()
		{
			var results = await _client.GetExtensionsAsync().ConfigureAwait(false);
			var firstResult = results.Extensions.FirstOrDefault();

			var result = await _client.GetExtensionGlobalConfigurationAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetActiveGateExtensionModulesAsync()
		{
			var results = await _client.GetExtensionsAsync().ConfigureAwait(false);
			var firstResult = results.Extensions.FirstOrDefault();

			var result = await _client.GetActiveGateExtensionModulesAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetExtensionHostsAsync()
		{
			var result = await _client.GetExtensionHostsAsync(ServiceTechnologies.Dotnet).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
