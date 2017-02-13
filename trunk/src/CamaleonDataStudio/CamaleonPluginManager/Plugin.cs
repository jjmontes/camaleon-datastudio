using ConnectionCamaleonDataStudio;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CamaleonPluginManager
{
    public class Plugin
    {
        private const string tagName = "name";
        private const string tagDll = "dll";

        public Plugin(string file)
        {
            var xml = File.ReadAllText(file);
            Name = GetTagContent(ref xml, tagName);
            Path = file;
            Folder = (new FileInfo(file)).DirectoryName;
            if (!Folder.EndsWith("\\")) Folder += "\\";
            Dll = Folder + GetTagContent(ref xml, tagDll);
        }

        public string Name { get; private set; }

        public string Path { get; private set; }

        public string Folder { get; private set; }

        private string Dll { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public IConnection Load()
        {
            IConnection typeIConnection = null;

            var assembly = Assembly.LoadFile(Dll);
            var types = assembly.GetExportedTypes();
            foreach (var type in types)
            {
                if (type.GetInterfaces().Contains(typeof(IConnection)))
                {
                    typeIConnection = (IConnection)Activator.CreateInstance(type);
                    break;
                }
            }

            return typeIConnection;
        }

        private string GetTagContent(ref string xml, string tag)
        {
            var tagStart = string.Format("<{0}>", tag);
            var tagEnd = string.Format("</{0}>", tag);

            var start = xml.IndexOf(tagStart, StringComparison.InvariantCultureIgnoreCase);
            if (start == -1) throw new PluginMissingConfigurationException(tag);
            start += tagStart.Length;
            var end = xml.IndexOf(tagEnd, start, StringComparison.InvariantCultureIgnoreCase);

            return xml.Substring(start, end - start);
        }
    }
}
