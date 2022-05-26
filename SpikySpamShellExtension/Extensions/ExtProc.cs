using System.Collections.Generic;
using System.Diagnostics;

namespace SpikySpamShellExtension
{
    internal static class ExtProc
    {

        internal static void Stop(string processName)
        {
            var procs = Process.GetProcessesByName(processName);
            foreach (var proc in procs)
            {
                proc.Kill();
                proc.WaitForExit(4000);
                proc.Dispose();
            }
        }

        internal static Process Start(string processName, string args = null, ProcessWindowStyle windowStyle = ProcessWindowStyle.Normal)
        {
            return Process.Start(new ProcessStartInfo()
            {
                FileName = processName,
                Arguments = args,
                WindowStyle = windowStyle,
            });
        }

        internal static void StartWait(string processName, List<string> args, ProcessWindowStyle windowStyle = ProcessWindowStyle.Normal)
        {
            foreach (var path in args)
            {
                StartWait(processName, path, windowStyle);
            }
        }
        private static void StartWait(string processName, string args = null, ProcessWindowStyle windowStyle = ProcessWindowStyle.Normal) => Process.Start(new ProcessStartInfo()
        {
            FileName = processName,
            Arguments = args,
            WindowStyle = windowStyle,
        }).WaitForExit();

    }
}
