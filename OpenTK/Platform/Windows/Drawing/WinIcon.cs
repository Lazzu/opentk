using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Windows.Drawing
{
    [CLSCompliant(false)]
    [StructLayout(LayoutKind.Sequential)]
    public struct WinIcon
    {
        public IconDirHeader header;
        public IconDirEntry[] entries;
        public byte[] imagedata;
    }

    [CLSCompliant(false)]
    [StructLayout(LayoutKind.Sequential)]
    public struct IconDirHeader
    {
        public ushort zerofillheader;
        public ushort filetype;
        public ushort numberofimages;
    }

    [CLSCompliant(false)]
    [StructLayout(LayoutKind.Sequential)]
    public struct IconDirEntry
    {
        public byte width;
        public byte height;
        public byte palette;
        public byte zerobit;
        public ushort colorplanes;
        public ushort bitsperpixel;
        public uint imagedatainbytes;
        public uint imagedataoffsetfromfilestart;
    }

    [CLSCompliant(false)]
    public static class WinIconHelper
    {
        private const int HEADERSIZE = 6;
        private const int ENTRYSIZE = 16;

        public static IconDirHeader GetHeader()
        {
            IconDirHeader header = new IconDirHeader();
            header.zerofillheader = 0;
            header.filetype = 1;
            header.numberofimages = 1;

            return header;
        }

        public static IconDirEntry GetEntry(byte width, byte height, uint datasize)
        {
            IconDirEntry entry = new IconDirEntry();
            entry.width = width;
            entry.height = height;
            entry.palette = 0;
            entry.zerobit = 0;
            entry.colorplanes = 1;
            entry.bitsperpixel = 32;
            entry.imagedatainbytes = datasize;
            entry.imagedataoffsetfromfilestart = HEADERSIZE + ENTRYSIZE;

            return entry;
        }
    }
}
