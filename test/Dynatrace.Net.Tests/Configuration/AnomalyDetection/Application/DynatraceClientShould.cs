﻿using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAnomalyDetectionApplicationConfigurationAsync()
		{
			var result = await _client.GetAnomalyDetectionApplicationConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
