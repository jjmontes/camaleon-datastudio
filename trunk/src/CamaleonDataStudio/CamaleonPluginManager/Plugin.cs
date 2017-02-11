using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamaleonPluginManager
{
    public class Plugin
    {
        private const string tagNameStart = "<name>";
        private const string tagNameEnd = "</name>";

        public Plugin(string file)
        {
            var xml = File.ReadAllText(file);
            var start = xml.IndexOf(tagNameStart, StringComparison.InvariantCultureIgnoreCase);
            if (start == -1) throw new PluginMissingConfigurationException("name");
            start += tagNameStart.Length;
            var end = xml.IndexOf(tagNameEnd, start, StringComparison.InvariantCultureIgnoreCase);

            Name = xml.Substring(start, end - start);
            Path = file;
        }

        public string Name { get; private set; }

        public string Path { get; private set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
