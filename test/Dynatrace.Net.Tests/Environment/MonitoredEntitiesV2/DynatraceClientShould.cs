﻿using System.Linq;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetMonitoredEntitiesV2Async()
		{
			var result = await _client.GetMonitoredEntitiesV2Async(entitySelector:new EntitySelector { EntityType = "APPLICATION" }).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetMonitoredEntityV2Async()
		{
			var results = await _client.GetMonitoredEntitiesV2Async(entitySelector:new EntitySelector { EntityType = "APPLICATION" }).ConfigureAwait(false);
			var firstResult = results.Entities?.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetMonitoredEntityV2Async(firstResult.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetMonitoredEntityTypesV2Async()
		{
			var result = await _client.GetMonitoredEntityTypesV2Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetMonitoredEntityTypeV2Async()
		{
			var results = await _client.GetMonitoredEntityTypesV2Async().ConfigureAwait(false);
			var firstResult = results.Types.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetMonitoredEntityTypeV2Async(firstResult.Type).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
