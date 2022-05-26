using Microsoft.Win32;

namespace SpikySpamShellExtension
{
    internal static class ExtRegistry
    {

        private static RegistryKey GetKey(RegistryHive hive, string keyPath) => RegistryKey.OpenBaseKey(hive, RegistryView.Registry64)?.OpenSubKey(keyPath);

        private static RegistryKey SetKey(RegistryHive hive, string keyPath) => RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenSubKey(keyPath, true) ?? RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).CreateSubKey(keyPath, true);

        internal static void DeleteSubKeyTree(RegistryHive hive, string subKey) => RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).DeleteSubKeyTree(subKey, true);

        internal static string GetStringValue(RegistryHive hive, string path, string name) => GetKey(hive, path)?.GetValue(name) as string;

        internal static void SetValue(RegistryHive hive, string path, string name, object value, RegistryValueKind type) => SetKey(hive, path).SetValue(name, value, type);

    }
}
