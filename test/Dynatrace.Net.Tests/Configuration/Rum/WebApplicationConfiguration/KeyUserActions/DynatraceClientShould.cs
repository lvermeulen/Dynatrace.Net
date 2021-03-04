﻿using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetKeyUserActionsAsync()
		{
			var results = await _client.GetAllWebApplicationsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();

			var result = await _client.GetKeyUserActionsAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
