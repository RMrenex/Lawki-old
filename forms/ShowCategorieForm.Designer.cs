
namespace LowaPasswd.forms
{
    partial class ShowCategorieForm
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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopSubPanel = new System.Windows.Forms.Panel();
            this.labelAddName = new System.Windows.Forms.Label();
            this.inputAddCredentialName = new System.Windows.Forms.TextBox();
            this.pictureBoxAddCredential = new System.Windows.Forms.PictureBox();
            this.labelAddPassword = new System.Windows.Forms.Label();
            this.labelAddLogin = new System.Windows.Forms.Label();
            this.inputaddCredentialPassword = new System.Windows.Forms.TextBox();
            this.inputaddCredentialLogin = new System.Windows.Forms.TextBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TopPanel.SuspendLayout();
            this.TopSubPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddCredential)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 610);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(970, 60);
            this.bottomPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.Controls.Add(this.TopSubPanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(970, 173);
            this.TopPanel.TabIndex = 1;
            // 
            // TopSubPanel
            // 
            this.TopSubPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopSubPanel.Controls.Add(this.labelAddName);
            this.TopSubPanel.Controls.Add(this.inputAddCredentialName);
            this.TopSubPanel.Controls.Add(this.pictureBoxAddCredential);
            this.TopSubPanel.Controls.Add(this.labelAddPassword);
            this.TopSubPanel.Controls.Add(this.labelAddLogin);
            this.TopSubPanel.Controls.Add(this.inputaddCredentialPassword);
            this.TopSubPanel.Controls.Add(this.inputaddCredentialLogin);
            this.TopSubPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TopSubPanel.Location = new System.Drawing.Point(0, 80);
            this.TopSubPanel.Name = "TopSubPanel";
            this.TopSubPanel.Size = new System.Drawing.Size(970, 93);
            this.TopSubPanel.TabIndex = 0;
            // 
            // labelAddName
            // 
            this.labelAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.labelAddName.Location = new System.Drawing.Point(63, 17);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(220, 23);
            this.labelAddName.TabIndex = 6;
            this.labelAddName.Text = "Nom";
            this.labelAddName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputAddCredentialName
            // 
            this.inputAddCredentialName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.inputAddCredentialName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAddCredentialName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAddCredentialName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.inputAddCredentialName.Location = new System.Drawing.Point(63, 43);
            this.inputAddCredentialName.Multiline = true;
            this.inputAddCredentialName.Name = "inputAddCredentialName";
            this.inputAddCredentialName.Size = new System.Drawing.Size(220, 35);
            this.inputAddCredentialName.TabIndex = 5;
            this.inputAddCredentialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxAddCredential
            // 
            this.pictureBoxAddCredential.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAddCredential.Image = global::LowaPasswd.Properties.Resources.add_credential;
            this.pictureBoxAddCredential.Location = new System.Drawing.Point(833, 37);
            this.pictureBoxAddCredential.Name = "pictureBoxAddCredential";
            this.pictureBoxAddCredential.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAddCredential.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAddCredential.TabIndex = 4;
            this.pictureBoxAddCredential.TabStop = false;
            this.pictureBoxAddCredential.Click += new System.EventHandler(this.pictureBoxAddCredential_Click);
            this.pictureBoxAddCredential.MouseEnter += new System.EventHandler(this.pictureBoxAddCredential_MouseEnter);
            this.pictureBoxAddCredential.MouseLeave += new System.EventHandler(this.pictureBoxAddCredential_MouseLeave);
            // 
            // labelAddPassword
            // 
            this.labelAddPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.labelAddPassword.Location = new System.Drawing.Point(586, 17);
            this.labelAddPassword.Name = "labelAddPassword";
            this.labelAddPassword.Size = new System.Drawing.Size(220, 23);
            this.labelAddPassword.TabIndex = 3;
            this.labelAddPassword.Text = "MOT DE PASSE";
            this.labelAddPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddLogin
            // 
            this.labelAddLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelAddLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.labelAddLogin.Location = new System.Drawing.Point(326, 17);
            this.labelAddLogin.Name = "labelAddLogin";
            this.labelAddLogin.Size = new System.Drawing.Size(220, 23);
            this.labelAddLogin.TabIndex = 2;
            this.labelAddLogin.Text = "IDENTIFIANT";
            this.labelAddLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputaddCredentialPassword
            // 
            this.inputaddCredentialPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.inputaddCredentialPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputaddCredentialPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputaddCredentialPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.inputaddCredentialPassword.Location = new System.Drawing.Point(586, 43);
            this.inputaddCredentialPassword.Multiline = true;
            this.inputaddCredentialPassword.Name = "inputaddCredentialPassword";
            this.inputaddCredentialPassword.PasswordChar = '*';
            this.inputaddCredentialPassword.Size = new System.Drawing.Size(220, 35);
            this.inputaddCredentialPassword.TabIndex = 1;
            this.inputaddCredentialPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputaddCredentialLogin
            // 
            this.inputaddCredentialLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.inputaddCredentialLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputaddCredentialLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputaddCredentialLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.inputaddCredentialLogin.Location = new System.Drawing.Point(326, 43);
            this.inputaddCredentialLogin.Multiline = true;
            this.inputaddCredentialLogin.Name = "inputaddCredentialLogin";
            this.inputaddCredentialLogin.Size = new System.Drawing.Size(220, 35);
            this.inputaddCredentialLogin.TabIndex = 0;
            this.inputaddCredentialLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 173);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(4, 437);
            this.LeftPanel.TabIndex = 2;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(4, 173);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(966, 437);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // ShowCategorieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 670);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowCategorieForm";
            this.Text = "ShowCategorieForm";
            this.TopPanel.ResumeLayout(false);
            this.TopSubPanel.ResumeLayout(false);
            this.TopSubPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddCredential)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel TopSubPanel;
        private System.Windows.Forms.TextBox inputaddCredentialLogin;
        private System.Windows.Forms.TextBox inputaddCredentialPassword;
        private System.Windows.Forms.Label labelAddPassword;
        private System.Windows.Forms.Label labelAddLogin;
        private System.Windows.Forms.PictureBox pictureBoxAddCredential;
        private System.Windows.Forms.Label labelAddName;
        private System.Windows.Forms.TextBox inputAddCredentialName;
    }
}