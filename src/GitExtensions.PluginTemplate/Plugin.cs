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
            /// <summary>
            /// See: https://github.com/gitextensions/gitextensions.plugintemplate/wiki/GitPluginBase#protected-void-setnameanddescriptionstring-name
            /// </summary>
            SetNameAndDescription("Plugin Template");

            /// <summary>
            /// See: https://github.com/gitextensions/gitextensions.plugintemplate/wiki/GitPluginBase#public-image-icon--get-protected-set-
            /// </summary>
            Icon = Resources.Icon;
        }


        /// <summary>
        /// See: https://github.com/gitextensions/gitextensions.plugintemplate/wiki/GitPluginBase#public-virtual-void-registerigituicommands-gituicommands
        /// </summary>
        public override void Register(IGitUICommands gitUiCommands)
        {
            
        }


        /// <summary>
        /// See: https://github.com/gitextensions/gitextensions.plugintemplate/wiki/GitPluginBase#public-virtual-void-unregisterigituicommands-gituicommands
        /// </summary>
        public override void Unregister(IGitUICommands gitUiCommands)
        {
            
        }


        /// <summary>
        /// See: https://github.com/gitextensions/gitextensions.plugintemplate/wiki/GitPluginBase#public-abstract-bool-executegituieventargs-args
        /// </summary>
        public override bool Execute(GitUIEventArgs gitUIEventArgs)
        {
            MessageBox.Show(gitUIEventArgs.OwnerForm, "Hello from the Plugin Template.", "Git Extensions");
            return true;
        }
    }
}
