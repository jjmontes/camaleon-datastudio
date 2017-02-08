using System;
using System.Collections.Generic;
using System.IO;

namespace CamaleonPluginManager
{
    public class PluginManager
    {
        private static readonly Lazy<PluginManager> _lazy = new Lazy<PluginManager>(() => new PluginManager());

        private readonly string _pluginFolder;

        private PluginManager()
        {
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            _pluginFolder = string.Format("{0}/Plugins/", currentDirectory);
            Directory.CreateDirectory(_pluginFolder);
        }      
  
        public static PluginManager Instance { get { return _lazy.Value; } }

        public string[] Plugins 
        { 
            get 
            {
                var plugins = new List<string>();
                var files = new List<string>();
                GetFilesInFolder(files, _pluginFolder, "Plugin.xml");
                GetPluginsName(plugins, files);

                return plugins.ToArray(); 
            } 
        }

        private void GetFilesInFolder(List<string> files, string root, string filePattern, SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            var folders = Directory.GetDirectories(root);

            foreach (var folder in folders)
            {
                var indexFile = Directory.GetFiles(folder, filePattern, searchOption);
                if (indexFile.Length == 0) continue;

                files.AddRange(indexFile);
            }
        }

        private void GetPluginsName(List<string> plugins, IEnumerable<string> files)
        {
            const string tagNameStart = "<name>";
            const string tagNameEnd = "</name>";

            foreach (var file in files)
            {
                var xml = File.ReadAllText(file);
                var start = xml.IndexOf(tagNameStart, StringComparison.InvariantCultureIgnoreCase);
                if (start == -1) continue;
                start += tagNameStart.Length;
                
                var end = xml.IndexOf(tagNameEnd, start, StringComparison.InvariantCultureIgnoreCase);
                plugins.Add(xml.Substring(start, end - start));
            }
        }
    }
}
