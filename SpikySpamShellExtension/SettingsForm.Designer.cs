namespace SpikySpamShellExtension
{
    public partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.chkFullContextMenu = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.grdShellItems = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrowse = new System.Windows.Forms.DataGridViewImageColumn();
            this.colArguments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srcShellItems = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboTemplates = new System.Windows.Forms.ComboBox();
            this.lblTemplates = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdShellItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcShellItems)).BeginInit();
            this.SuspendLayout();
            // 
            // chkFullContextMenu
            // 
            this.chkFullContextMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkFullContextMenu.AutoSize = true;
            this.chkFullContextMenu.Location = new System.Drawing.Point(8, 336);
            this.chkFullContextMenu.Name = "chkFullContextMenu";
            this.chkFullContextMenu.Size = new System.Drawing.Size(153, 17);
            this.chkFullContextMenu.TabIndex = 0;
            this.chkFullContextMenu.Text = "Revert to full context menu";
            this.chkFullContextMenu.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(570, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(650, 332);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grdShellItems
            // 
            this.grdShellItems.AllowUserToAddRows = false;
            this.grdShellItems.AllowUserToResizeColumns = false;
            this.grdShellItems.AllowUserToResizeRows = false;
            this.grdShellItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdShellItems.AutoGenerateColumns = false;
            this.grdShellItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdShellItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShellItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colDescription,
            this.colExtensions,
            this.colCommand,
            this.colBrowse,
            this.colArguments});
            this.grdShellItems.DataSource = this.srcShellItems;
            this.grdShellItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdShellItems.Location = new System.Drawing.Point(8, 32);
            this.grdShellItems.MultiSelect = false;
            this.grdShellItems.Name = "grdShellItems";
            this.grdShellItems.RowHeadersVisible = false;
            this.grdShellItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdShellItems.ShowEditingIcon = false;
            this.grdShellItems.Size = new System.Drawing.Size(719, 298);
            this.grdShellItems.TabIndex = 3;
            this.grdShellItems.VirtualMode = true;
            this.grdShellItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdShellItems_CellContentClick);
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.Width = 130;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // colExtensions
            // 
            this.colExtensions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colExtensions.DataPropertyName = "Extensions";
            this.colExtensions.FillWeight = 73.85786F;
            this.colExtensions.HeaderText = "Extensions";
            this.colExtensions.Name = "colExtensions";
            this.colExtensions.Width = 75;
            // 
            // colCommand
            // 
            this.colCommand.DataPropertyName = "Command";
            this.colCommand.FillWeight = 73.85786F;
            this.colCommand.HeaderText = "Command";
            this.colCommand.Name = "colCommand";
            // 
            // colBrowse
            // 
            this.colBrowse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colBrowse.HeaderText = "";
            this.colBrowse.Image = global::SpikySpamShellExtension.Properties.Resources.baseline_folder_open_black_24dp;
            this.colBrowse.Name = "colBrowse";
            this.colBrowse.Width = 22;
            // 
            // colArguments
            // 
            this.colArguments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colArguments.DataPropertyName = "Arguments";
            this.colArguments.HeaderText = "Arguments";
            this.colArguments.Name = "colArguments";
            this.colArguments.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(639, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "➕";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboTemplates
            // 
            this.cboTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTemplates.FormattingEnabled = true;
            this.cboTemplates.Location = new System.Drawing.Point(68, 8);
            this.cboTemplates.Name = "cboTemplates";
            this.cboTemplates.Size = new System.Drawing.Size(200, 21);
            this.cboTemplates.TabIndex = 5;
            // 
            // lblTemplates
            // 
            this.lblTemplates.AutoSize = true;
            this.lblTemplates.Location = new System.Drawing.Point(8, 12);
            this.lblTemplates.Name = "lblTemplates";
            this.lblTemplates.Size = new System.Drawing.Size(59, 13);
            this.lblTemplates.TabIndex = 6;
            this.lblTemplates.Text = "Templates:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(695, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(31, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "➖";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTemplates);
            this.Controls.Add(this.cboTemplates);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdShellItems);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkFullContextMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 400);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdShellItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcShellItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFullContextMenu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView grdShellItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboTemplates;
        private System.Windows.Forms.Label lblTemplates;
        private System.Windows.Forms.BindingSource srcShellItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.DataGridViewComboBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommand;
        private System.Windows.Forms.DataGridViewImageColumn colBrowse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArguments;
    }
}

