using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Configuration.MobileSymbolication.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly MobileOsTypesConverter s_mobileOsTypesConverter = new MobileOsTypesConverter();

		private IFlurlRequest GetMobileSymbolicationUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/symfiles");
		}

		public async Task<IEnumerable<SymbolFile>> GetAllMobileSymbolicationMetadatasAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetMobileSymbolicationUrl()
				.GetJsonIfNotEmptyAsync(Enumerable.Empty<SymbolFile>(), cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<SymbolFileStorageInfo> GetMobileSymbolicationStorageInformationAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetMobileSymbolicationUrl()
				.AppendPathSegment("info")
				.GetJsonAsync<SymbolFileStorageInfo>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<SupportedVersion> GetMobileSymbolicationSupportedFileFormatForIosAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetMobileSymbolicationUrl()
				.AppendPathSegment("ios")
				.AppendPathSegment("supportedversion")
				.GetJsonAsync<SupportedVersion>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<SymbolFileList> GetMobileSymbolicationMetadataAsync(string applicationId, CancellationToken cancellationToken = default)
		{
			var response = await GetMobileSymbolicationUrl()
				.AppendPathSegment(applicationId)
				.GetJsonAsync<SymbolFileList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> PutMobileSymbolicationFileAsync(string applicationId, string packageName, MobileOsTypes os, string versionCode, string versionName,
			byte[] body, string contentType = null, CancellationToken cancellationToken = default)
		{
			var response = await GetMobileSymbolicationUrl()
				.If(contentType != null, request => request.WithHeader("content-type", contentType))
				.AppendPathSegment(applicationId)
				.AppendPathSegment(packageName)
				.AppendPathSegment(s_mobileOsTypesConverter.ConvertToString(os))
				.AppendPathSegment(versionCode)
				.AppendPathSegment(versionName)
				.PutAsync(new ByteArrayContent(body), cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteMobileSymbolicationFilesAsync(string applicationId, CancellationToken cancellationToken = default)
		{
			var response = await GetMobileSymbolicationUrl()
				.AppendPathSegment(applicationId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<SymbolFile> GetMobileSymbolicationMetadataForAppVersionAsync(string applicationId, string packageName, MobileOsTypes os, string versionCode, string versionName,
			CancellationToken cancellationToken = default)
		{
			var response = await GetMobileSymbolicationUrl()
				.AppendPathSegment(applicationId)
				.AppendPathSegment(packageName)
				.AppendPathSegment(s_mobileOsTypesConverter.ConvertToString(os))
				.AppendPathSegment(versionCode)
				.AppendPathSegment(versionName)
				.GetJsonAsync<SymbolFile>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteMobileSymbolicationFileForAppVersionAsync(string applicationId, string packageName, MobileOsTypes os, string versionCode, string versionName,
			CancellationToken cancellationToken = default)
		{
			var response = await GetMobileSymbolicationUrl()
				.AppendPathSegment(applicationId)
				.AppendPathSegment(packageName)
				.AppendPathSegment(s_mobileOsTypesConverter.ConvertToString(os))
				.AppendPathSegment(versionCode)
				.AppendPathSegment(versionName)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> ChangePinMobileSymbolicationFileAsync(string applicationId, string packageName, MobileOsTypes os, string versionCode, string versionName,
			SymbolFilePinning body, CancellationToken cancellationToken = default)
		{
			var response = await GetMobileSymbolicationUrl()
				.AppendPathSegment(applicationId)
				.AppendPathSegment(packageName)
				.AppendPathSegment(s_mobileOsTypesConverter.ConvertToString(os))
				.AppendPathSegment(versionCode)
				.AppendPathSegment(versionName)
				.AppendPathSegment("pinning")
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
