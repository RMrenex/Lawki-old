
namespace Lawki.forms
{
    partial class SettingsForm
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
            this.labelSetupFile = new System.Windows.Forms.Label();
            this.labelLang = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.comboBoxLang = new MetroFramework.Controls.MetroComboBox();
            this.inputFileSetup = new System.Windows.Forms.TextBox();
            this.comboBoxTheme = new MetroFramework.Controls.MetroComboBox();
            this.buttonSearchFile = new System.Windows.Forms.Button();
            this.buttonSaveChanged = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSetupFile
            // 
            this.labelSetupFile.BackColor = System.Drawing.Color.Transparent;
            this.labelSetupFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetupFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.labelSetupFile.Location = new System.Drawing.Point(238, 255);
            this.labelSetupFile.Name = "labelSetupFile";
            this.labelSetupFile.Size = new System.Drawing.Size(264, 29);
            this.labelSetupFile.TabIndex = 0;
            this.labelSetupFile.Text = "Changer le répertoire d\'installation :";
            this.labelSetupFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLang
            // 
            this.labelLang.BackColor = System.Drawing.Color.Transparent;
            this.labelLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.labelLang.Location = new System.Drawing.Point(238, 290);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(264, 29);
            this.labelLang.TabIndex = 0;
            this.labelLang.Text = "Choisir la langue :";
            this.labelLang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTheme
            // 
            this.labelTheme.BackColor = System.Drawing.Color.Transparent;
            this.labelTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.labelTheme.Location = new System.Drawing.Point(238, 325);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(264, 29);
            this.labelTheme.TabIndex = 0;
            this.labelTheme.Text = "Changer le thème :";
            this.labelTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.comboBoxLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.ItemHeight = 23;
            this.comboBoxLang.Items.AddRange(new object[] {
            "Francais/French",
            "Anglais/English"});
            this.comboBoxLang.Location = new System.Drawing.Point(524, 290);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.PromptText = "Sélection langue";
            this.comboBoxLang.Size = new System.Drawing.Size(140, 29);
            this.comboBoxLang.TabIndex = 1;
            this.comboBoxLang.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboBoxLang.UseCustomBackColor = true;
            this.comboBoxLang.UseCustomForeColor = true;
            this.comboBoxLang.UseSelectable = true;
            // 
            // inputFileSetup
            // 
            this.inputFileSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.inputFileSetup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputFileSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFileSetup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.inputFileSetup.Location = new System.Drawing.Point(524, 255);
            this.inputFileSetup.Multiline = true;
            this.inputFileSetup.Name = "inputFileSetup";
            this.inputFileSetup.ReadOnly = true;
            this.inputFileSetup.Size = new System.Drawing.Size(140, 29);
            this.inputFileSetup.TabIndex = 2;
            this.inputFileSetup.WordWrap = false;
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.comboBoxTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.ItemHeight = 23;
            this.comboBoxTheme.Items.AddRange(new object[] {
            "Défaut/Default",
            "Blanc/White",
            "Noir/Black"});
            this.comboBoxTheme.Location = new System.Drawing.Point(524, 325);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.PromptText = "Sélection thème";
            this.comboBoxTheme.Size = new System.Drawing.Size(140, 29);
            this.comboBoxTheme.TabIndex = 1;
            this.comboBoxTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboBoxTheme.UseCustomBackColor = true;
            this.comboBoxTheme.UseCustomForeColor = true;
            this.comboBoxTheme.UseSelectable = true;
            // 
            // buttonSearchFile
            // 
            this.buttonSearchFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.buttonSearchFile.Location = new System.Drawing.Point(670, 255);
            this.buttonSearchFile.Name = "buttonSearchFile";
            this.buttonSearchFile.Size = new System.Drawing.Size(29, 29);
            this.buttonSearchFile.TabIndex = 3;
            this.buttonSearchFile.Text = "...";
            this.buttonSearchFile.UseVisualStyleBackColor = true;
            this.buttonSearchFile.Click += new System.EventHandler(this.buttonSearchFile_Click);
            // 
            // buttonSaveChanged
            // 
            this.buttonSaveChanged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanged.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.buttonSaveChanged.Location = new System.Drawing.Point(362, 411);
            this.buttonSaveChanged.Name = "buttonSaveChanged";
            this.buttonSaveChanged.Size = new System.Drawing.Size(140, 29);
            this.buttonSaveChanged.TabIndex = 4;
            this.buttonSaveChanged.Text = "Sauvergarder";
            this.buttonSaveChanged.UseVisualStyleBackColor = true;
            this.buttonSaveChanged.Click += new System.EventHandler(this.buttonSaveChanged_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(970, 670);
            this.Controls.Add(this.buttonSaveChanged);
            this.Controls.Add(this.buttonSearchFile);
            this.Controls.Add(this.inputFileSetup);
            this.Controls.Add(this.comboBoxTheme);
            this.Controls.Add(this.comboBoxLang);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.labelLang);
            this.Controls.Add(this.labelSetupFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSetupFile;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.Label labelTheme;
        private MetroFramework.Controls.MetroComboBox comboBoxLang;
        private System.Windows.Forms.TextBox inputFileSetup;
        private MetroFramework.Controls.MetroComboBox comboBoxTheme;
        private System.Windows.Forms.Button buttonSearchFile;
        private System.Windows.Forms.Button buttonSaveChanged;
    }
}