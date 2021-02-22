using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class HypervisorTypesConverter : JsonEnumConverter<HypervisorTypes>
	{
		private static readonly Dictionary<HypervisorTypes, string> s_pairs = new Dictionary<HypervisorTypes, string>
		{
			[HypervisorTypes.Ahv] = "AHV",
			[HypervisorTypes.Hyperv] = "HYPERV",
			[HypervisorTypes.Kvm] = "KVM",
			[HypervisorTypes.Lpar] = "LPAR",
			[HypervisorTypes.Qemu] = "QEMU",
			[HypervisorTypes.Virtualbox] = "VIRTUALBOX",
			[HypervisorTypes.Vmware] = "VMWARE",
			[HypervisorTypes.Wpar] = "WPAR",
			[HypervisorTypes.Xen] = "XEN"
		};

		protected override Dictionary<HypervisorTypes, string> Pairs => s_pairs;
		protected override string EntityString => "hypervisor type";
	}
}
