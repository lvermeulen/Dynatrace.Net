using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllRealUserMonitoringJavaScriptCodeInjectedApplicationsAsync()
		{
			var result = await _client.GetAllRealUserMonitoringJavaScriptCodeInjectedApplicationsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetRealUserMonitoringJavaScriptCodeLatestVersionAsync()
		{
			string result = await _client.GetRealUserMonitoringJavaScriptCodeLatestVersionAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetRealUserMonitoringJavaScriptCodeCurrentVersionAsync()
		{
			var results = await _client.GetAllRealUserMonitoringJavaScriptCodeInjectedApplicationsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			string result = await _client.GetRealUserMonitoringJavaScriptCodeCurrentVersionAsync(firstResult.ApplicationId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetRealUserMonitoringJavaScriptCodeJavaScriptTagAsync()
		{
			var results = await _client.GetAllRealUserMonitoringJavaScriptCodeInjectedApplicationsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			string result = await _client.GetRealUserMonitoringJavaScriptCodeJavaScriptTagAsync(firstResult.ApplicationId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetRealUserMonitoringJavaScriptCodeOneAgentJavaScriptTagAsync()
		{
			var results = await _client.GetAllRealUserMonitoringJavaScriptCodeInjectedApplicationsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			string result = await _client.GetRealUserMonitoringJavaScriptCodeOneAgentJavaScriptTagAsync(firstResult.ApplicationId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetRealUserMonitoringJavaScriptCodeSynchronousCodeSnippetAsync()
		{
			var results = await _client.GetAllRealUserMonitoringJavaScriptCodeInjectedApplicationsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			string result = await _client.GetRealUserMonitoringJavaScriptCodeSynchronousCodeSnippetAsync(firstResult.ApplicationId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetRealUserMonitoringJavaScriptCodeAsynchronousCodeSnippetAsync()
		{
			var results = await _client.GetAllRealUserMonitoringJavaScriptCodeInjectedApplicationsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			string result = await _client.GetRealUserMonitoringJavaScriptCodeAsynchronousCodeSnippetAsync(firstResult.ApplicationId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetRealUserMonitoringJavaScriptCodeInlineCodeAsync()
		{
			var results = await _client.GetAllRealUserMonitoringJavaScriptCodeInjectedApplicationsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			string result = await _client.GetRealUserMonitoringJavaScriptCodeInlineCodeAsync(firstResult.ApplicationId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
