﻿namespace HotkeyBinder
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.defaultInputButton = new System.Windows.Forms.Button();
            this.uploadInputFileButton = new System.Windows.Forms.Button();
            this.uploadedInputFilePath = new System.Windows.Forms.TextBox();
            this.ModifyKeybind = new System.Windows.Forms.Button();
            this.ResetKeybind = new System.Windows.Forms.Button();
            this.keybinds = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bShift = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bCtrl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bAlt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bCmd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keybinds)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultInputButton
            // 
            this.defaultInputButton.Location = new System.Drawing.Point(457, 12);
            this.defaultInputButton.Name = "defaultInputButton";
            this.defaultInputButton.Size = new System.Drawing.Size(75, 23);
            this.defaultInputButton.TabIndex = 0;
            this.defaultInputButton.Text = "Default";
            this.defaultInputButton.UseVisualStyleBackColor = true;
            this.defaultInputButton.Click += new System.EventHandler(this.DefaultInputButton_Click);
            // 
            // uploadInputFileButton
            // 
            this.uploadInputFileButton.Location = new System.Drawing.Point(376, 12);
            this.uploadInputFileButton.Name = "uploadInputFileButton";
            this.uploadInputFileButton.Size = new System.Drawing.Size(75, 23);
            this.uploadInputFileButton.TabIndex = 1;
            this.uploadInputFileButton.Text = "Import";
            this.uploadInputFileButton.UseVisualStyleBackColor = true;
            this.uploadInputFileButton.Click += new System.EventHandler(this.UploadInputFileButton_Click);
            // 
            // uploadedInputFilePath
            // 
            this.uploadedInputFilePath.Enabled = false;
            this.uploadedInputFilePath.Location = new System.Drawing.Point(28, 15);
            this.uploadedInputFilePath.Name = "uploadedInputFilePath";
            this.uploadedInputFilePath.Size = new System.Drawing.Size(342, 20);
            this.uploadedInputFilePath.TabIndex = 2;
            // 
            // ModifyKeybind
            // 
            this.ModifyKeybind.Location = new System.Drawing.Point(203, 415);
            this.ModifyKeybind.Name = "ModifyKeybind";
            this.ModifyKeybind.Size = new System.Drawing.Size(75, 23);
            this.ModifyKeybind.TabIndex = 4;
            this.ModifyKeybind.Text = "Modify";
            this.ModifyKeybind.UseVisualStyleBackColor = true;
            // 
            // ResetKeybind
            // 
            this.ResetKeybind.Location = new System.Drawing.Point(285, 414);
            this.ResetKeybind.Name = "ResetKeybind";
            this.ResetKeybind.Size = new System.Drawing.Size(75, 23);
            this.ResetKeybind.TabIndex = 5;
            this.ResetKeybind.Text = "Reset";
            this.ResetKeybind.UseVisualStyleBackColor = true;
            this.ResetKeybind.Click += new System.EventHandler(this.ResetKeybind_Click);
            // 
            // keybinds
            // 
            this.keybinds.AllowUserToAddRows = false;
            this.keybinds.AllowUserToDeleteRows = false;
            this.keybinds.AllowUserToResizeColumns = false;
            this.keybinds.AllowUserToResizeRows = false;
            this.keybinds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keybinds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.Key,
            this.bShift,
            this.bCtrl,
            this.bAlt,
            this.bCmd});
            this.keybinds.Location = new System.Drawing.Point(12, 77);
            this.keybinds.Name = "keybinds";
            this.keybinds.RowHeadersVisible = false;
            this.keybinds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.keybinds.Size = new System.Drawing.Size(543, 331);
            this.keybinds.TabIndex = 6;
            this.keybinds.TabStop = false;
            this.keybinds.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Keybinds_CellEnter);
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Action.Frozen = true;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Action.Width = 62;
            // 
            // Key
            // 
            this.Key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Key.Frozen = true;
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Key.Width = 50;
            // 
            // bShift
            // 
            this.bShift.Frozen = true;
            this.bShift.HeaderText = "bShift";
            this.bShift.Name = "bShift";
            this.bShift.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bShift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bShift.Width = 59;
            // 
            // bCtrl
            // 
            this.bCtrl.Frozen = true;
            this.bCtrl.HeaderText = "bCtrl";
            this.bCtrl.Name = "bCtrl";
            this.bCtrl.Width = 59;
            // 
            // bAlt
            // 
            this.bAlt.Frozen = true;
            this.bAlt.HeaderText = "bAlt";
            this.bAlt.Name = "bAlt";
            this.bAlt.Width = 59;
            // 
            // bCmd
            // 
            this.bCmd.Frozen = true;
            this.bCmd.HeaderText = "bCmd";
            this.bCmd.Name = "bCmd";
            this.bCmd.Width = 59;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(376, 41);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.keybinds);
            this.Controls.Add(this.ResetKeybind);
            this.Controls.Add(this.ModifyKeybind);
            this.Controls.Add(this.uploadedInputFilePath);
            this.Controls.Add(this.uploadInputFileButton);
            this.Controls.Add(this.defaultInputButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hotkey Binder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keybinds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button defaultInputButton;
        private System.Windows.Forms.Button uploadInputFileButton;
        private System.Windows.Forms.TextBox uploadedInputFilePath;
        private System.Windows.Forms.Button ModifyKeybind;
        private System.Windows.Forms.Button ResetKeybind;
        private System.Windows.Forms.DataGridView keybinds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewComboBoxColumn Key;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bShift;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bCtrl;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bAlt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bCmd;
        private System.Windows.Forms.Button saveButton;
    }
}

