using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static SpikySpamShellExtension.Constants;

namespace SpikySpamShellExtension
{
    public partial class SettingsForm : Form
    {
        private List<ShellItem> templates = ShellItems.Get(Templates);
        private bool fullContextMenu = false;

        public SettingsForm()
        {
            InitializeComponent();
            SetFullContextMenu();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            grdShellItems.AutoGenerateColumns = false;
            grdShellItems.DataSource = srcShellItems;

            colType.BindEnumToCombobox<AssociationType>();

            cboTemplates.DisplayMember = Description;
            cboTemplates.DataSource = templates
                .Select(x => new { Description = x.Description })
                .Distinct()
                .ToList();

            srcShellItems.DataSource = ShellItems.Get();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<ShellItem> template = templates
                .Where(x => x.Description == cboTemplates.Text)
                .ToList();
            foreach (ShellItem t in template)
                srcShellItems.Add(new ShellItem(t.Type == 0 ? AssociationType.AllFilesAndFolders : t.Type, t.Extensions, t.Description, t.Command, t.Arguments));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (srcShellItems.Current != null)
                srcShellItems.RemoveCurrent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ShellItems.Set((List<ShellItem>)srcShellItems.DataSource);

            if (fullContextMenu != chkFullContextMenu.Checked)
            {
                if (chkFullContextMenu.Checked)
                {
                    ExtRegistry.SetValue(RegistryHive.CurrentUser, RegFullContextMenu, null, string.Empty, RegistryValueKind.String);
                }
                else
                    ExtRegistry.DeleteSubKeyTree(RegistryHive.CurrentUser, RegFullContextMenu);

                ExtOS.RestartExplorer();
            }

            btnCancel.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdShellItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                if (dlgOpenFile.ShowDialog() == DialogResult.OK)
                {
                    var fileName = dlgOpenFile.FileName;
                    var fileCaption = Path.GetFileNameWithoutExtension(fileName);

                    ((ShellItem)srcShellItems.Current).Command = fileName;
                    if (string.IsNullOrEmpty(((ShellItem)srcShellItems.Current).Description))
                        ((ShellItem)srcShellItems.Current).Description = fileCaption;

                    grdShellItems.Refresh();
                }
            }
        }

        private void SetFullContextMenu()
        {
            chkFullContextMenu.Visible = false;
            if (ExtOS.OSVersion() == 11)
            {
                fullContextMenu = (ExtRegistry.GetStringValue(RegistryHive.CurrentUser, RegFullContextMenu, null) == string.Empty);
                chkFullContextMenu.Visible = true;
                chkFullContextMenu.Checked = fullContextMenu;
            }
        }
    }
}
