using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Environment.RealUserMonitoringJavaScriptCode.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetRealUserMonitoringJavaScriptCodeUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/rum");
		}

		public async Task<IEnumerable<InjectedApplication>> GetAllRealUserMonitoringJavaScriptCodeInjectedApplicationsAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetRealUserMonitoringJavaScriptCodeUrl()
				.AppendPathSegment("manualApps")
				.GetJsonAsync<IEnumerable<InjectedApplication>>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> GetRealUserMonitoringJavaScriptCodeLatestVersionAsync(CancellationToken cancellationToken = default)
		{
			string response = await GetRealUserMonitoringJavaScriptCodeUrl()
				.AppendPathSegment("jsLatestVersion")
				.GetStringAsync(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> GetRealUserMonitoringJavaScriptCodeCurrentVersionAsync(string applicationId, CancellationToken cancellationToken = default)
		{
			string response = await GetRealUserMonitoringJavaScriptCodeUrl()
				.AppendPathSegment("appRevision")
				.AppendPathSegment(applicationId)
				.GetStringAsync(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> GetRealUserMonitoringJavaScriptCodeJavaScriptTagAsync(string applicationId, CancellationToken cancellationToken = default)
		{
			string response = await GetRealUserMonitoringJavaScriptCodeUrl()
				.AppendPathSegment("jsTagComplete")
				.AppendPathSegment(applicationId)
				.GetStringAsync(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> GetRealUserMonitoringJavaScriptCodeOneAgentJavaScriptTagAsync(string applicationId, CancellationToken cancellationToken = default)
		{
			string response = await GetRealUserMonitoringJavaScriptCodeUrl()
				.AppendPathSegment("jsTag")
				.AppendPathSegment(applicationId)
				.GetStringAsync(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> GetRealUserMonitoringJavaScriptCodeSynchronousCodeSnippetAsync(string applicationId, CancellationToken cancellationToken = default)
		{
			string response = await GetRealUserMonitoringJavaScriptCodeUrl()
				.AppendPathSegment("syncCS")
				.AppendPathSegment(applicationId)
				.GetStringAsync(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> GetRealUserMonitoringJavaScriptCodeAsynchronousCodeSnippetAsync(string applicationId, CancellationToken cancellationToken = default)
		{
			string response = await GetRealUserMonitoringJavaScriptCodeUrl()
				.AppendPathSegment("asyncCS")
				.AppendPathSegment(applicationId)
				.GetStringAsync(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<string> GetRealUserMonitoringJavaScriptCodeInlineCodeAsync(string applicationId, CancellationToken cancellationToken = default)
		{
			string response = await GetRealUserMonitoringJavaScriptCodeUrl()
				.AppendPathSegment("jsInlineScript")
				.AppendPathSegment(applicationId)
				.GetStringAsync(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}