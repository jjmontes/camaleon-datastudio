using System;

namespace CamaleonPluginManager
{
    public class PluginMissingConfigurationException : ApplicationException
    {
        public PluginMissingConfigurationException(string property)
            : base(string.Format("Property '{0}' doesn't exist into config file.", property))
        {
        }
    }
}
