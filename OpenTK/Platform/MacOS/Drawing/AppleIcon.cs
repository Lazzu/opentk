using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS.Drawing
{
    /// <summary>
    /// Apple Icon Format, all data in big endian.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AppleIcon
    {
        AppleHeader header;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AppleHeader
    {
        byte[] Magicheader;
        byte[] Filelength;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AppleIconData
    {
        byte[] AppleIcontype;
        byte[] IconDataLength;
        byte[] IconData;
    }

    public static class AppleIconHelper
    {
        //Magicheader
        public static readonly byte[] MHeader = new byte[4] { 0x69, 0x63, 0x6e, 0x73 };

        //Icontypes
        public static readonly byte[] AppleicontypeICP4 = new byte[4] { 0x69, 0x63, 0x70, 4 };
        public static readonly byte[] AppleicontypeICP5 = new byte[4] { 0x69, 0x63, 0x70, 5 };
        public static readonly byte[] AppleicontypeICP6 = new byte[4] { 0x69, 0x63, 0x70, 6 };
        public static readonly byte[] AppleicontypeICP7 = new byte[4] { 0x69, 0x63, 0x70, 7 };
    }
}
