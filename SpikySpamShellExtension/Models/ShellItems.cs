using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace SpikySpamShellExtension
{
    internal static class ShellItems
    {

        private static string GetJson(string fileName = "")
        {
            var assemblyDLL = Assembly.GetExecutingAssembly();
            var assemblyName = Path.GetFileNameWithoutExtension(assemblyDLL.Location);
            var assemblyDirectory = Path.GetDirectoryName(assemblyDLL.Location);
            return Path.Combine(assemblyDirectory, string.IsNullOrEmpty(fileName) ? assemblyName + Constants.Json : fileName);
        }

        internal static List<ShellItem> Get(string fileName = "")
        {
            var jsonFile = GetJson(fileName);

            if (!File.Exists(jsonFile))
                return new List<ShellItem>();

            using (StreamReader r = new StreamReader(jsonFile))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<ShellItem>>(json);
            }

        }

        internal static void Set(List<ShellItem> shellItems)
        {
            var jsonFile = GetJson();
            string json = JsonConvert.SerializeObject(shellItems);
            File.WriteAllText(jsonFile, json);

        }

    }
}
