using SharpShell.Attributes;
using SharpShell.SharpContextMenu;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static SpikySpamShellExtension.ExtIO;

namespace SpikySpamShellExtension
{
    [ComVisible(true)]
    [COMServerAssociation(SharpShell.Attributes.AssociationType.AllFilesAndFolders)]
    [COMServerAssociation(SharpShell.Attributes.AssociationType.Directory)]
    [COMServerAssociation(SharpShell.Attributes.AssociationType.DirectoryBackground)]
    [COMServerAssociation(SharpShell.Attributes.AssociationType.DesktopBackground)]
    [COMServerAssociation(SharpShell.Attributes.AssociationType.Drive)]
    [COMServerAssociation(SharpShell.Attributes.AssociationType.UnknownFiles)]
    public class SpikySpamShellExtension : SharpContextMenu
    {

        private ContextMenuStrip menu = new ContextMenuStrip();

        protected override bool CanShowMenu()
        {
            UpdateMenu();
            return true;
        }

        private void UpdateMenu()
        {
            menu.Dispose();
            menu = CreateMenu();
        }

        protected override ContextMenuStrip CreateMenu()
        {
            menu.Items.Clear();
            var mainMenu = new ToolStripMenuItem()
            {
                Text = Properties.Resources.ApplicationTitle,
                Image = Properties.Resources.baloo_24,
            };

            string path = "";
            List<ShellItem> shellItems = ShellItems.Get();
            if (SelectedItemPaths.Count() == 1)
            {
                path = SelectedItemPaths.First();
                FileAttributes attr = File.GetAttributes(path);

                if (IsDrive(path))
                    shellItems = shellItems.Where(x => (x.Type == AssociationType.Drive)).ToList();
                else
                    if (attr.HasFlag(FileAttributes.Directory))
                    shellItems = shellItems.Where(x => (x.Type == AssociationType.AllFilesAndFolders) || (x.Type == AssociationType.Folder) || (x.Type == AssociationType.Directory)).ToList();
                else
                    shellItems = shellItems.Where(x => (x.Type == AssociationType.AllFilesAndFolders) || (x.Type == AssociationType.AllFiles)).ToList();

                var ext = Path.GetExtension(path).ToLower();
                shellItems = shellItems.Where(x => string.IsNullOrEmpty(x.Extensions) || x.Extensions.ToLower().Split(Constants.Semi).Contains(ext)).ToList();
            }
            else
            {
                shellItems = shellItems.Where(x => (x.Type == AssociationType.DirectoryBackground) || (x.Type == AssociationType.DesktopBackground)).ToList();
            }

            if (shellItems != null)
            {
                if (shellItems.Count > 0)
                {
                    foreach (ShellItem shellItem in shellItems)
                    {
                        var itemMenu = new ToolStripMenuItem()
                        {
                            Text = shellItem.Description,
                            Image = ExtractIconFromFilePath(shellItem.Command).ToBitmap()
                        };
                        itemMenu.Click += (sender, args) => StartCommand(path, shellItem);
                        mainMenu.DropDownItems.Add(itemMenu);
                    }
                    mainMenu.DropDownItems.Add(new ToolStripSeparator());
                }
            }

            var settingsMenu = new ToolStripMenuItem()
            {
                Text = Properties.Resources.Settings + Constants.Dots,
                Image = Properties.Resources.round_settings_black_24dp,

            };
            settingsMenu.Click += (sender, args) => ShowSettingsForm();
            mainMenu.DropDownItems.Add(settingsMenu);

            menu.Items.Add(mainMenu);
            return menu;
        }

        private void ShowSettingsForm()
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
            form.Dispose();

        }

        private void StartCommand(string path, ShellItem shellItem)
        {
            var filename = shellItem.Command;
            var arguments = shellItem.Arguments.Replace(Constants.Param, string.Format(@"""{0}""", path));

            if (File.Exists(filename))
                System.Diagnostics.Process.Start(filename, arguments);
            else
                MessageBox.Show(string.Format(Properties.Resources.FileNotExists, filename));
        }
    }
}