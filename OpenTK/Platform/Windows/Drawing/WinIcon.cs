using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Windows.Drawing
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WinIcon
    {
        IconDirHeader header;
        IconDirEntry[] entries;
        byte[] imagedata;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct IconDirHeader
    {
        ushort zerofillheader;
        ushort filetype;
        ushort numberofimages;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct IconDirEntry
    {
        byte width;
        byte height;
        byte palette;
        byte zerobit;
        ushort colorplanes;
        ushort bitsperpixel;
        uint imagedatainbytes;
        uint imagedataoffsetfromfilestart;
    }

    public static class WinIconHelper
    {
        public static bool LoadIcon(string filepath, out WinIcon icon)
        {
            icon = new WinIcon();
            return false;
        }
    }
}
