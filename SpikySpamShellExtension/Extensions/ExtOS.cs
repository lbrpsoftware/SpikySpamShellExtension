using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace SpikySpamShellExtension
{
    internal static class ExtOS
    {

        [DllImport(Constants.WinBrand, CharSet = CharSet.Unicode)]
        [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
        static extern string BrandingFormatString(string format);

        internal static int OSVersion()
        {
            var Version = BrandingFormatString("%WINDOWS_LONG%");
            var Numbers = new string(Version.Where(char.IsDigit).ToArray());
            return int.Parse(Numbers);
        }

        internal static void RestartExplorer()
        {

            const string PROC_EXPLORER = "explorer";
            var openedFolders = GetOpenedFolders().ToList();
            try
            {
                ExtProc.Stop(PROC_EXPLORER);
                ExtProc.StartWait(PROC_EXPLORER, openedFolders, ProcessWindowStyle.Minimized);
            }
            finally
            {
                if (openedFolders.Count == 0)
                    ExtProc.Start(PROC_EXPLORER);
            }

        }

        private static IEnumerable<string> GetOpenedFolders()
        {
            const string comShellApp = "Shell.Application";
            foreach (var folder in CreateFromProgID(comShellApp).Windows())
            {
                yield return folder.Document.Folder.Self.Path;
            }
        }

        private static dynamic CreateFromProgID(string progID)
        {
            var type = Type.GetTypeFromProgID(progID);
            return Activator.CreateInstance(type);
        }


    }
}
