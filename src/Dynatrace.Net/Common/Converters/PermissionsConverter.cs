using System.Collections.Generic;
using Dynatrace.Net.Environment.Tokens.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PermissionsConverter : JsonEnumConverter<Permissions>
	{
		private static readonly Dictionary<Permissions, string> s_pairs = new Dictionary<Permissions, string>
		{
			[Permissions.ActiveGateCertManagement] = "ActiveGateCertManagement",
			[Permissions.AdvancedSyntheticIntegration] = "AdvancedSyntheticIntegration",
			[Permissions.AppMonIntegration] = "AppMonIntegration",
			[Permissions.CaptureRequestData] = "CaptureRequestData",
			[Permissions.DtaqlAccess] = "DTAQLAccess",
			[Permissions.DataExport] = "DataExport",
			[Permissions.DataImport] = "DataImport",
			[Permissions.DataPrivacy] = "DataPrivacy",
			[Permissions.Davis] = "Davis",
			[Permissions.DcrumIntegration] = "DcrumIntegration",
			[Permissions.DiagnosticExport] = "DiagnosticExport",
			[Permissions.DssFileManagement] = "DssFileManagement",
			[Permissions.ExternalSyntheticIntegration] = "ExternalSyntheticIntegration",
			[Permissions.InstallerDownload] = "InstallerDownload",
			[Permissions.LogExport] = "LogExport",
			[Permissions.LogImport] = "LogImport",
			[Permissions.MemoryDump] = "MemoryDump",
			[Permissions.Mobile] = "Mobile",
			[Permissions.PluginUpload] = "PluginUpload",
			[Permissions.ReadConfig] = "ReadConfig",
			[Permissions.ReadSyntheticData] = "ReadSyntheticData",
			[Permissions.RestRequestForwarding] = "RestRequestForwarding",
			[Permissions.RumBrowserExtension] = "RumBrowserExtension",
			[Permissions.RumJavaScriptTagManagement] = "RumJavaScriptTagManagement",
			[Permissions.SupportAlert] = "SupportAlert",
			[Permissions.TenantTokenManagement] = "TenantTokenManagement",
			[Permissions.UserSessionAnonymization] = "UserSessionAnonymization",
			[Permissions.ViewDashboard] = "ViewDashboard",
			[Permissions.ViewReport] = "ViewReport",
			[Permissions.WriteConfig] = "WriteConfig",
			[Permissions.WriteSyntheticData] = "WriteSyntheticData",
			[Permissions.ActiveGatesRead] = "activeGates.read",
			[Permissions.ActiveGatesWrite] = "activeGates.write",
			[Permissions.AuditLogsRead] = "auditLogs.read",
			[Permissions.CredentialVaultRead] = "credentialVault.read",
			[Permissions.CredentialVaultWrite] = "credentialVault.write",
			[Permissions.EntitiesRead] = "entities.read",
			[Permissions.EntitiesWrite] = "entities.write",
			[Permissions.MetricsRead] = "metrics.read",
			[Permissions.NetworkZonesRead] = "networkZones.read",
			[Permissions.NetworkZonesWrite] = "networkZones.write",
			[Permissions.SyntheticLocationsRead] = "syntheticLocations.read",
			[Permissions.SyntheticLocationsWrite] = "syntheticLocations.write"
		};

		protected override Dictionary<Permissions, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "permission";
	}
}
