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

        public Plugin[] Plugins 
        { 
            get 
            {
                var plugins = new List<Plugin>();
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

        private void GetPluginsName(List<Plugin> plugins, IEnumerable<string> files)
        {
            foreach (var file in files)
            {
                plugins.Add(new Plugin(file));
            }
        }
    }
}
