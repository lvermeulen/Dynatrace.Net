using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetActiveGatesAsync()
		{
			var result = await _client.GetActiveGatesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetActiveGateAsync()
		{
			var results = await _client.GetActiveGatesAsync().ConfigureAwait(false);
			var firstResult = results.ActiveGates.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetActiveGateAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAutoUpdateJobsAsync()
		{
			var results = await _client.GetActiveGatesAsync().ConfigureAwait(false);
			var firstResult = results.ActiveGates.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetAutoUpdateJobsAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAutoUpdateJobAsync()
		{
			var results = await _client.GetActiveGatesAsync().ConfigureAwait(false);
			var firstResult = results.ActiveGates.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var jobs = await _client.GetAutoUpdateJobsAsync(firstResult?.Id).ConfigureAwait(false);
			var firstJob = jobs.UpdateJobs?.FirstOrDefault();
			if (firstJob is null)
			{
				return;
			}

			var result = await _client.GetAutoUpdateJobAsync(firstResult?.Id, firstJob?.JobId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetActiveGatesWithAutoUpdateJobsAsync()
		{
			var result = await _client.GetActiveGatesWithAutoUpdateJobsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
