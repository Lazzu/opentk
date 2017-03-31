using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

using ImageSharp;
using ImageSharp.Colors;
using ImageSharp.Formats;

using OpenTK.Platform.Windows.Drawing;

namespace OpenTK.Platform.Common.Drawing
{
    [CLSCompliant(false)]
    public sealed class Icon : IDisposable
    {
        public WinIcon WinIcon16;
        public WinIcon WinIcon32;

        public byte[] PNG16;
        public byte[] PNG32;

        public void FromPNGFile(string file)
        {
            using(FileStream stream = new FileStream(file, FileMode.Open))
            {
                using (MemoryStream memstream = new MemoryStream())
                {
                    stream.CopyTo(memstream);
                    FromPNGStream(memstream);
                }
            }
        }

        public void FromPNGStream(MemoryStream stream)
        {
            byte[] bytes = stream.ToArray();
            FromPNGByteArray(bytes);
        }

        public void FromPNGByteArray(byte[] PNGbytes)
        {
            Image image = new Image(PNGbytes);

            //PNG
            //Create16x16
            using (Image image16 = new Image(image))
            using (MemoryStream stream = new MemoryStream())
            {
                image16.Resize<Color>(16, 16);
                image16.SaveAsPng<Color>(stream);
                PNG16 = stream.ToArray();
            }
            
            //Create32x32
            using (Image image32 = new Image(image))
            using (MemoryStream stream = new MemoryStream())
            {
                image32.Resize<Color>(32, 32);
                image32.SaveAsPng<Color>(stream);
                PNG32 = stream.ToArray();
            }

            //WinIcon
            //Create 16x16

            WinIcon16 = new WinIcon();
            WinIcon16.header = WinIconHelper.GetHeader();
            WinIcon16.entries = new IconDirEntry[1]; 
            WinIcon16.entries[1] = WinIconHelper.GetEntry((byte)16, (byte)16, (uint)PNG16.Length);
            WinIcon16.imagedata = PNG16;

            //Create 32x32
            WinIcon32 = new WinIcon();
            WinIcon32.header = WinIconHelper.GetHeader();
            WinIcon32.entries = new IconDirEntry[1];
            WinIcon32.entries[1] = WinIconHelper.GetEntry((byte)32, (byte)32, (uint)PNG32.Length);
            WinIcon32.imagedata = PNG32;

            //AppleIcon
            //Total garbage
        }

        private bool disposedValue = false; // To detect redundant calls


        void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Icon() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
    }
}
