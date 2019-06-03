using GitExtensions.PluginTemplate.Properties;
using GitUIPluginInterfaces;
using ResourceManager;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitExtensions.PluginTemplate
{
    /// <summary>
    /// An empty Git Extensions plugin implementation.
    /// </summary>
    [Export(typeof(IGitPlugin))]
    public class Plugin : GitPluginBase
    {
        public Plugin()
        {
            Name = "PluginTemplate";
            Description = "Plugin Template";
            Icon = Resources.Icon;
        }

        public override bool Execute(GitUIEventArgs e)
        {
            MessageBox.Show(e.OwnerForm, "Hello from the Plugin Template.", "Git Extensions");
            return true;
        }
    }
}
