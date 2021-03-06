﻿using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAnomalyDetectionVmwareConfigurationAsync()
		{
			var result = await _client.GetAnomalyDetectionVmwareConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
