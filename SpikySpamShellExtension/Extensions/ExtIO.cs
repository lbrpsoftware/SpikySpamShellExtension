using System;
using System.Drawing;
using System.IO;

namespace SpikySpamShellExtension
{
    internal static class ExtIO
    {

        internal static bool IsDrive(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            return (d.Parent == null);
        }

        internal static Icon ExtractIconFromFilePath(string executablePath)
        {
            Icon result = null;
            try
            {
                result = Icon.ExtractAssociatedIcon(executablePath);
            }
            catch (Exception)
            {
            }
            return result;
        }

    }
}
