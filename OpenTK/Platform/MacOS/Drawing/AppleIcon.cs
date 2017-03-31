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
        
    }
}
