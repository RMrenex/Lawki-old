
namespace Lawki.forms {
    partial class Notification {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelNotificationtext = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.buttonNotification = new System.Windows.Forms.Button();
            this.bottomLeftPanel = new System.Windows.Forms.Panel();
            this.bottomRightPanel = new System.Windows.Forms.Panel();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNotificationtext
            // 
            this.labelNotificationtext.BackColor = System.Drawing.Color.Transparent;
            this.labelNotificationtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotificationtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.labelNotificationtext.Location = new System.Drawing.Point(39, 29);
            this.labelNotificationtext.Name = "labelNotificationtext";
            this.labelNotificationtext.Size = new System.Drawing.Size(318, 51);
            this.labelNotificationtext.TabIndex = 1;
            this.labelNotificationtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.bottomPanel.Controls.Add(this.buttonNotification);
            this.bottomPanel.Controls.Add(this.bottomRightPanel);
            this.bottomPanel.Controls.Add(this.bottomLeftPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 110);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(400, 40);
            this.bottomPanel.TabIndex = 2;
            // 
            // buttonNotification
            // 
            this.buttonNotification.BackColor = System.Drawing.Color.Transparent;
            this.buttonNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNotification.FlatAppearance.BorderSize = 0;
            this.buttonNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.buttonNotification.Location = new System.Drawing.Point(175, 0);
            this.buttonNotification.Name = "buttonNotification";
            this.buttonNotification.Size = new System.Drawing.Size(50, 40);
            this.buttonNotification.TabIndex = 0;
            this.buttonNotification.Text = "OK";
            this.buttonNotification.UseVisualStyleBackColor = false;
            this.buttonNotification.Click += new System.EventHandler(this.buttonNotification_Click);
            this.buttonNotification.MouseEnter += new System.EventHandler(this.buttonNotification_MouseEnter);
            this.buttonNotification.MouseLeave += new System.EventHandler(this.buttonNotification_MouseLeave);
            // 
            // bottomLeftPanel
            // 
            this.bottomLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bottomLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.bottomLeftPanel.Name = "bottomLeftPanel";
            this.bottomLeftPanel.Size = new System.Drawing.Size(175, 40);
            this.bottomLeftPanel.TabIndex = 0;
            // 
            // bottomRightPanel
            // 
            this.bottomRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bottomRightPanel.Location = new System.Drawing.Point(225, 0);
            this.bottomRightPanel.Name = "bottomRightPanel";
            this.bottomRightPanel.Size = new System.Drawing.Size(175, 40);
            this.bottomRightPanel.TabIndex = 1;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.labelNotificationtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification";
            this.TopMost = true;
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNotificationtext;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button buttonNotification;
        private System.Windows.Forms.Panel bottomRightPanel;
        private System.Windows.Forms.Panel bottomLeftPanel;
    }
}