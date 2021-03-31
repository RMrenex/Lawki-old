
namespace LowaPasswd.forms
{
    partial class LoaderForm
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
            this.metroProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroProgressSpinner
            // 
            this.metroProgressSpinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.metroProgressSpinner.Location = new System.Drawing.Point(516, 230);
            this.metroProgressSpinner.Maximum = 100;
            this.metroProgressSpinner.Name = "metroProgressSpinner";
            this.metroProgressSpinner.Size = new System.Drawing.Size(128, 128);
            this.metroProgressSpinner.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroProgressSpinner.TabIndex = 0;
            this.metroProgressSpinner.UseCustomBackColor = true;
            this.metroProgressSpinner.UseCustomForeColor = true;
            this.metroProgressSpinner.UseSelectable = true;
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.labelMessage.Location = new System.Drawing.Point(516, 361);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(128, 23);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Loading...";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.metroProgressSpinner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.Text = "Loader";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner;
        private System.Windows.Forms.Label labelMessage;
    }
}