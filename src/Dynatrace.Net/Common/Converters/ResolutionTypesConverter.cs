using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ResolutionTypesConverter : JsonEnumConverter<ResolutionTypes>
	{
		private static readonly Dictionary<ResolutionTypes, string> s_pairs = new Dictionary<ResolutionTypes, string>
		{
			[ResolutionTypes.Cga] = "CGA",
			[ResolutionTypes.Dci2K] = "DCI2K",
			[ResolutionTypes.Dci4K] = "DCI4K",
			[ResolutionTypes.Dvga] = "DVGA",
			[ResolutionTypes.Fhd] = "FHD",
			[ResolutionTypes.Fwvga] = "FWVGA",
			[ResolutionTypes.Fwxga] = "FWXGA",
			[ResolutionTypes.GhdPlus] = "GHDPlus",
			[ResolutionTypes.Hd] = "HD",
			[ResolutionTypes.Hqvga] = "HQVGA",
			[ResolutionTypes.Hqvga2] = "HQVGA2",
			[ResolutionTypes.Hsxga] = "HSXGA",
			[ResolutionTypes.Huxga] = "HUXGA",
			[ResolutionTypes.Hvga] = "HVGA",
			[ResolutionTypes.Hxga] = "HXGA",
			[ResolutionTypes.Ntsc] = "NTSC",
			[ResolutionTypes.Pal] = "PAL",
			[ResolutionTypes.QHd] = "QHD",
			[ResolutionTypes.Qvga] = "QQVGA",
			[ResolutionTypes.Qsxga] = "QSXGA",
			[ResolutionTypes.Quxga] = "QUXGA",
			[ResolutionTypes.Qvga] = "QVGA",
			[ResolutionTypes.Qwxga] = "QWXGA",
			[ResolutionTypes.Qxga] = "QXGA",
			[ResolutionTypes.Svga] = "SVGA",
			[ResolutionTypes.Sxga] = "SXGA",
			[ResolutionTypes.SxgaMinus] = "SXGAMinus",
			[ResolutionTypes.SxgaPlus] = "SXGAPlus",
			[ResolutionTypes.Uga] = "UGA",
			[ResolutionTypes.Uhd16K] = "UHD16K",
			[ResolutionTypes.Uhd4K] = "UHD4K",
			[ResolutionTypes.Uhd8K] = "UHD8K",
			[ResolutionTypes.UhdPlus] = "UHDPlus",
			[ResolutionTypes.Unknown] = "UNKNOWN",
			[ResolutionTypes.Uwqhd] = "UWQHD",
			[ResolutionTypes.Uxga] = "UXGA",
			[ResolutionTypes.Vga] = "VGA",
			[ResolutionTypes.Whsxga] = "WHSXGA",
			[ResolutionTypes.Whuxga] = "WHUXGA",
			[ResolutionTypes.Whxga] = "WHXGA",
			[ResolutionTypes.Wqsxga] = "WQSXGA",
			[ResolutionTypes.Wquxga] = "WQUXGA",
			[ResolutionTypes.Wqvga] = "WQVGA",
			[ResolutionTypes.Wqvga2] = "WQVGA2",
			[ResolutionTypes.Wqvga3] = "WQVGA3",
			[ResolutionTypes.Wqxga] = "WQXGA",
			[ResolutionTypes.Wqxga2] = "WQXGA2",
			[ResolutionTypes.Wsvga] = "WSVGA",
			[ResolutionTypes.Wsvga2] = "WSVGA2",
			[ResolutionTypes.Wsxga] = "WSXGA",
			[ResolutionTypes.WsxgaPlus] = "WSXGAPlus",
			[ResolutionTypes.Wuxga] = "WUXGA",
			[ResolutionTypes.Wvga] = "WVGA",
			[ResolutionTypes.Wvga2] = "WVGA2",
			[ResolutionTypes.Wxga] = "WXGA",
			[ResolutionTypes.Wxga2] = "WXGA2",
			[ResolutionTypes.Wxga3] = "WXGA3",
			[ResolutionTypes.WxgaPlus] = "WXGAPlus",
			[ResolutionTypes.Xga] = "XGA",
			[ResolutionTypes.Xgaplus] = "XGAPLUS",
			[ResolutionTypes._1280x854] = "_1280x854",
			[ResolutionTypes.NHd] = "nHD",
			[ResolutionTypes.QHd] = "qHD"
		};

		protected override Dictionary<ResolutionTypes, string> Pairs => s_pairs;

		protected override string EntityString => "resolution type";
	}
}
