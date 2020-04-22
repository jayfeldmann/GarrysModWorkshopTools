namespace Gmod_Workshop_Tool
{
    partial class Main_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_folderLocation = new System.Windows.Forms.TextBox();
            this.btn_openFolder = new System.Windows.Forms.Button();
            this.btn_gmaOutLoc = new System.Windows.Forms.Button();
            this.txb_gmaOutLoc = new System.Windows.Forms.TextBox();
            this.txb_AddonName = new System.Windows.Forms.TextBox();
            this.btn_createGma = new System.Windows.Forms.Button();
            this.btn_rootDir = new System.Windows.Forms.Button();
            this.txb_rootDir = new System.Windows.Forms.TextBox();
            this.cbx_update = new System.Windows.Forms.CheckBox();
            this.txb_wsId = new System.Windows.Forms.TextBox();
            this.btn_openIcon = new System.Windows.Forms.Button();
            this.txb_iconPath = new System.Windows.Forms.TextBox();
            this.btn_updateGmaLocation = new System.Windows.Forms.Button();
            this.txb_updateGmaLocation = new System.Windows.Forms.TextBox();
            this.txb_changeNotes = new System.Windows.Forms.TextBox();
            this.cbx_changeNotes = new System.Windows.Forms.CheckBox();
            this.btn_updateAddon = new System.Windows.Forms.Button();
            this.btn_updateIcon = new System.Windows.Forms.Button();
            this.outTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txb_folderLocation
            // 
            this.txb_folderLocation.AllowDrop = true;
            this.txb_folderLocation.Location = new System.Drawing.Point(179, 48);
            this.txb_folderLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_folderLocation.Name = "txb_folderLocation";
            this.txb_folderLocation.Size = new System.Drawing.Size(616, 22);
            this.txb_folderLocation.TabIndex = 1;
            this.txb_folderLocation.Text = "Addon folder path here...";
            this.txb_folderLocation.DragDrop += new System.Windows.Forms.DragEventHandler(this.txb_folderLocation_DragDrop);
            this.txb_folderLocation.DragEnter += new System.Windows.Forms.DragEventHandler(this.txb_folderLocation_DragEnter);
            // 
            // btn_openFolder
            // 
            this.btn_openFolder.Location = new System.Drawing.Point(16, 46);
            this.btn_openFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_openFolder.Name = "btn_openFolder";
            this.btn_openFolder.Size = new System.Drawing.Size(155, 28);
            this.btn_openFolder.TabIndex = 2;
            this.btn_openFolder.Text = "Open Addon Folder";
            this.btn_openFolder.UseVisualStyleBackColor = true;
            this.btn_openFolder.Click += new System.EventHandler(this.btn_openFolder_Click);
            // 
            // btn_gmaOutLoc
            // 
            this.btn_gmaOutLoc.Location = new System.Drawing.Point(16, 81);
            this.btn_gmaOutLoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_gmaOutLoc.Name = "btn_gmaOutLoc";
            this.btn_gmaOutLoc.Size = new System.Drawing.Size(155, 28);
            this.btn_gmaOutLoc.TabIndex = 3;
            this.btn_gmaOutLoc.Text = "GMA Out Location";
            this.btn_gmaOutLoc.UseVisualStyleBackColor = true;
            this.btn_gmaOutLoc.Click += new System.EventHandler(this.btn_gmaOutLoc_Click);
            // 
            // txb_gmaOutLoc
            // 
            this.txb_gmaOutLoc.Location = new System.Drawing.Point(179, 80);
            this.txb_gmaOutLoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_gmaOutLoc.Name = "txb_gmaOutLoc";
            this.txb_gmaOutLoc.Size = new System.Drawing.Size(616, 22);
            this.txb_gmaOutLoc.TabIndex = 4;
            this.txb_gmaOutLoc.Text = "Output path here...";
            // 
            // txb_AddonName
            // 
            this.txb_AddonName.Location = new System.Drawing.Point(16, 16);
            this.txb_AddonName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_AddonName.Name = "txb_AddonName";
            this.txb_AddonName.Size = new System.Drawing.Size(779, 22);
            this.txb_AddonName.TabIndex = 5;
            this.txb_AddonName.Text = "Addon Name... (No Spaces!)";
            this.txb_AddonName.TextChanged += new System.EventHandler(this.txb_AddonName_TextChanged);
            // 
            // btn_createGma
            // 
            this.btn_createGma.Location = new System.Drawing.Point(16, 154);
            this.btn_createGma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_createGma.Name = "btn_createGma";
            this.btn_createGma.Size = new System.Drawing.Size(780, 28);
            this.btn_createGma.TabIndex = 6;
            this.btn_createGma.Text = "Create GMA File";
            this.btn_createGma.UseVisualStyleBackColor = true;
            this.btn_createGma.Click += new System.EventHandler(this.btn_createGma_Click);
            // 
            // btn_rootDir
            // 
            this.btn_rootDir.Location = new System.Drawing.Point(17, 118);
            this.btn_rootDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_rootDir.Name = "btn_rootDir";
            this.btn_rootDir.Size = new System.Drawing.Size(153, 28);
            this.btn_rootDir.TabIndex = 7;
            this.btn_rootDir.Text = "Gmod root directory";
            this.btn_rootDir.UseVisualStyleBackColor = true;
            this.btn_rootDir.Click += new System.EventHandler(this.btn_rootDir_Click);
            // 
            // txb_rootDir
            // 
            this.txb_rootDir.Location = new System.Drawing.Point(179, 118);
            this.txb_rootDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_rootDir.Name = "txb_rootDir";
            this.txb_rootDir.Size = new System.Drawing.Size(616, 22);
            this.txb_rootDir.TabIndex = 8;
            // 
            // cbx_update
            // 
            this.cbx_update.AutoSize = true;
            this.cbx_update.Location = new System.Drawing.Point(17, 191);
            this.cbx_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_update.Name = "cbx_update";
            this.cbx_update.Size = new System.Drawing.Size(128, 21);
            this.cbx_update.TabIndex = 9;
            this.cbx_update.Text = "Update addon?";
            this.cbx_update.UseVisualStyleBackColor = true;
            this.cbx_update.CheckedChanged += new System.EventHandler(this.cbx_update_CheckedChanged);
            // 
            // txb_wsId
            // 
            this.txb_wsId.Enabled = false;
            this.txb_wsId.Location = new System.Drawing.Point(160, 191);
            this.txb_wsId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_wsId.Name = "txb_wsId";
            this.txb_wsId.Size = new System.Drawing.Size(132, 22);
            this.txb_wsId.TabIndex = 10;
            this.txb_wsId.Text = "Workshop ID";
            // 
            // btn_openIcon
            // 
            this.btn_openIcon.Location = new System.Drawing.Point(17, 220);
            this.btn_openIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_openIcon.Name = "btn_openIcon";
            this.btn_openIcon.Size = new System.Drawing.Size(153, 28);
            this.btn_openIcon.TabIndex = 11;
            this.btn_openIcon.Text = "Open Icon";
            this.btn_openIcon.UseVisualStyleBackColor = true;
            this.btn_openIcon.Click += new System.EventHandler(this.btn_openIcon_Click);
            // 
            // txb_iconPath
            // 
            this.txb_iconPath.Location = new System.Drawing.Point(179, 224);
            this.txb_iconPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_iconPath.Name = "txb_iconPath";
            this.txb_iconPath.Size = new System.Drawing.Size(616, 22);
            this.txb_iconPath.TabIndex = 12;
            this.txb_iconPath.Text = "Icon path...";
            // 
            // btn_updateGmaLocation
            // 
            this.btn_updateGmaLocation.Location = new System.Drawing.Point(17, 257);
            this.btn_updateGmaLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_updateGmaLocation.Name = "btn_updateGmaLocation";
            this.btn_updateGmaLocation.Size = new System.Drawing.Size(153, 28);
            this.btn_updateGmaLocation.TabIndex = 13;
            this.btn_updateGmaLocation.Text = "GMA Location";
            this.btn_updateGmaLocation.UseVisualStyleBackColor = true;
            this.btn_updateGmaLocation.Click += new System.EventHandler(this.btn_updateGmaLocation_Click);
            // 
            // txb_updateGmaLocation
            // 
            this.txb_updateGmaLocation.Location = new System.Drawing.Point(179, 257);
            this.txb_updateGmaLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_updateGmaLocation.Name = "txb_updateGmaLocation";
            this.txb_updateGmaLocation.Size = new System.Drawing.Size(616, 22);
            this.txb_updateGmaLocation.TabIndex = 14;
            this.txb_updateGmaLocation.Text = "GMA Location...";
            // 
            // txb_changeNotes
            // 
            this.txb_changeNotes.Enabled = false;
            this.txb_changeNotes.Location = new System.Drawing.Point(409, 191);
            this.txb_changeNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_changeNotes.Name = "txb_changeNotes";
            this.txb_changeNotes.Size = new System.Drawing.Size(385, 22);
            this.txb_changeNotes.TabIndex = 16;
            this.txb_changeNotes.Text = "Enter Changenotes Here...";
            // 
            // cbx_changeNotes
            // 
            this.cbx_changeNotes.AutoSize = true;
            this.cbx_changeNotes.Location = new System.Drawing.Point(303, 193);
            this.cbx_changeNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_changeNotes.Name = "cbx_changeNotes";
            this.cbx_changeNotes.Size = new System.Drawing.Size(94, 21);
            this.cbx_changeNotes.TabIndex = 17;
            this.cbx_changeNotes.Text = "Changes?";
            this.cbx_changeNotes.UseVisualStyleBackColor = true;
            this.cbx_changeNotes.CheckedChanged += new System.EventHandler(this.cbx_changeNotes_CheckedChanged);
            // 
            // btn_updateAddon
            // 
            this.btn_updateAddon.Location = new System.Drawing.Point(16, 293);
            this.btn_updateAddon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_updateAddon.Name = "btn_updateAddon";
            this.btn_updateAddon.Size = new System.Drawing.Size(384, 28);
            this.btn_updateAddon.TabIndex = 18;
            this.btn_updateAddon.Text = "Upload Addon";
            this.btn_updateAddon.UseVisualStyleBackColor = true;
            this.btn_updateAddon.Click += new System.EventHandler(this.btn_updateAddon_Click);
            // 
            // btn_updateIcon
            // 
            this.btn_updateIcon.Enabled = false;
            this.btn_updateIcon.Location = new System.Drawing.Point(409, 293);
            this.btn_updateIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_updateIcon.Name = "btn_updateIcon";
            this.btn_updateIcon.Size = new System.Drawing.Size(387, 28);
            this.btn_updateIcon.TabIndex = 19;
            this.btn_updateIcon.Text = "Update Icon";
            this.btn_updateIcon.UseVisualStyleBackColor = true;
            this.btn_updateIcon.Click += new System.EventHandler(this.btn_updateIcon_Click);
            // 
            // outTextBox
            // 
            this.outTextBox.Location = new System.Drawing.Point(803, 16);
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.Size = new System.Drawing.Size(391, 304);
            this.outTextBox.TabIndex = 20;
            this.outTextBox.Text = "";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 332);
            this.Controls.Add(this.outTextBox);
            this.Controls.Add(this.btn_updateIcon);
            this.Controls.Add(this.btn_updateAddon);
            this.Controls.Add(this.cbx_changeNotes);
            this.Controls.Add(this.txb_changeNotes);
            this.Controls.Add(this.txb_updateGmaLocation);
            this.Controls.Add(this.btn_updateGmaLocation);
            this.Controls.Add(this.txb_iconPath);
            this.Controls.Add(this.btn_openIcon);
            this.Controls.Add(this.txb_wsId);
            this.Controls.Add(this.cbx_update);
            this.Controls.Add(this.txb_rootDir);
            this.Controls.Add(this.btn_rootDir);
            this.Controls.Add(this.btn_createGma);
            this.Controls.Add(this.txb_AddonName);
            this.Controls.Add(this.txb_gmaOutLoc);
            this.Controls.Add(this.btn_gmaOutLoc);
            this.Controls.Add(this.btn_openFolder);
            this.Controls.Add(this.txb_folderLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.ShowIcon = false;
            this.Text = "Gmod Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_folderLocation;
        private System.Windows.Forms.Button btn_openFolder;
        private System.Windows.Forms.Button btn_gmaOutLoc;
        private System.Windows.Forms.TextBox txb_gmaOutLoc;
        private System.Windows.Forms.TextBox txb_AddonName;
        private System.Windows.Forms.Button btn_createGma;
        private System.Windows.Forms.Button btn_rootDir;
        private System.Windows.Forms.TextBox txb_rootDir;
        private System.Windows.Forms.CheckBox cbx_update;
        private System.Windows.Forms.TextBox txb_wsId;
        private System.Windows.Forms.Button btn_openIcon;
        private System.Windows.Forms.TextBox txb_iconPath;
        private System.Windows.Forms.Button btn_updateGmaLocation;
        private System.Windows.Forms.TextBox txb_updateGmaLocation;
        private System.Windows.Forms.TextBox txb_changeNotes;
        private System.Windows.Forms.CheckBox cbx_changeNotes;
        private System.Windows.Forms.Button btn_updateAddon;
        private System.Windows.Forms.Button btn_updateIcon;
        private System.Windows.Forms.RichTextBox outTextBox;
    }
}

