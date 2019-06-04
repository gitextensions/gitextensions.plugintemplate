using GitExtensions.PluginTemplate.Properties;
using GitUIPluginInterfaces;
using ResourceManager;
using System.ComponentModel.Composition;
using System.Windows.Forms;

namespace GitExtensions.PluginTemplate
{
    /// <summary>
    /// A template for Git Extensions plugins.
    /// </summary>
    [Export(typeof(IGitPlugin))]
    public class Plugin : GitPluginBase
    {
        public Plugin()
        {
            SetNameAndDescription("Plugin Template");
            Icon = Resources.Icon;
        }

        
        /// <summary>
        /// This method is called when the plugin is loaded (either when Git Extensions is opened or when repositories are switched).
        /// </summary>
        public override void Register(IGitUICommands gitUiCommands)
        {
            
        }


        /// <summary>
        /// This method is called when the plugin is unloaded (either when Git Extensions is closed or when repositories are switched).
        /// </summary>
        public override void Unregister(IGitUICommands gitUiCommands)
        {
            
        }


        /// <summary>
        /// This method is called from the Git Extensions "Plugins" menu.
        /// </summary>
        public override bool Execute(GitUIEventArgs gitUIEventArgs)
        {
            MessageBox.Show(gitUIEventArgs.OwnerForm, "Hello from the Plugin Template.", "Git Extensions");
            return true;
        }
    }
}
