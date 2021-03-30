
namespace LowaPass
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SideNav = new System.Windows.Forms.Panel();
            this.categorieDisplayer = new System.Windows.Forms.Panel();
            this.metroScrollBar = new MetroFramework.Controls.MetroScrollBar();
            this.SideNavFooter = new System.Windows.Forms.Panel();
            this.information = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.SideNavTopContent = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.btAddCat = new System.Windows.Forms.Button();
            this.Navbar = new System.Windows.Forms.Panel();
            this.SubOptionBox = new System.Windows.Forms.Panel();
            this.OptionBox = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.displayContent = new System.Windows.Forms.Panel();
            this.NavBorderBottom = new System.Windows.Forms.Panel();
            this.SideNavRightBorder = new System.Windows.Forms.Panel();
            this.SideNav.SuspendLayout();
            this.SideNavFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.SideNavTopContent.SuspendLayout();
            this.Navbar.SuspendLayout();
            this.SubOptionBox.SuspendLayout();
            this.OptionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.displayContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideNav
            // 
            this.SideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.SideNav.Controls.Add(this.categorieDisplayer);
            this.SideNav.Controls.Add(this.metroScrollBar);
            this.SideNav.Controls.Add(this.SideNavFooter);
            this.SideNav.Controls.Add(this.SideNavTopContent);
            this.SideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideNav.Location = new System.Drawing.Point(0, 0);
            this.SideNav.Name = "SideNav";
            this.SideNav.Size = new System.Drawing.Size(230, 700);
            this.SideNav.TabIndex = 0;
            // 
            // categorieDisplayer
            // 
            this.categorieDisplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categorieDisplayer.Location = new System.Drawing.Point(0, 173);
            this.categorieDisplayer.Name = "categorieDisplayer";
            this.categorieDisplayer.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.categorieDisplayer.Size = new System.Drawing.Size(220, 477);
            this.categorieDisplayer.TabIndex = 3;
            // 
            // metroScrollBar
            // 
            this.metroScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroScrollBar.LargeChange = 10;
            this.metroScrollBar.Location = new System.Drawing.Point(220, 173);
            this.metroScrollBar.Maximum = 100;
            this.metroScrollBar.Minimum = 0;
            this.metroScrollBar.MouseWheelBarPartitions = 10;
            this.metroScrollBar.Name = "metroScrollBar";
            this.metroScrollBar.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar.ScrollbarSize = 10;
            this.metroScrollBar.Size = new System.Drawing.Size(10, 477);
            this.metroScrollBar.TabIndex = 2;
            this.metroScrollBar.UseSelectable = true;
            // 
            // SideNavFooter
            // 
            this.SideNavFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.SideNavFooter.Controls.Add(this.information);
            this.SideNavFooter.Controls.Add(this.settings);
            this.SideNavFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SideNavFooter.Location = new System.Drawing.Point(0, 650);
            this.SideNavFooter.Name = "SideNavFooter";
            this.SideNavFooter.Size = new System.Drawing.Size(230, 50);
            this.SideNavFooter.TabIndex = 1;
            // 
            // information
            // 
            this.information.Dock = System.Windows.Forms.DockStyle.Right;
            this.information.Image = ((System.Drawing.Image)(resources.GetObject("information.Image")));
            this.information.Location = new System.Drawing.Point(171, 0);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(59, 50);
            this.information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.information.TabIndex = 1;
            this.information.TabStop = false;
            this.information.Click += new System.EventHandler(this.information_Click);
            this.information.MouseEnter += new System.EventHandler(this.information_MouseEnter);
            this.information.MouseLeave += new System.EventHandler(this.information_MouseLeave);
            // 
            // settings
            // 
            this.settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(59, 50);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.settings.TabIndex = 0;
            this.settings.TabStop = false;
            this.settings.MouseEnter += new System.EventHandler(this.settings_MouseEnter);
            this.settings.MouseLeave += new System.EventHandler(this.settings_MouseLeave);
            // 
            // SideNavTopContent
            // 
            this.SideNavTopContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.SideNavTopContent.Controls.Add(this.btLogin);
            this.SideNavTopContent.Controls.Add(this.btAddCat);
            this.SideNavTopContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.SideNavTopContent.Location = new System.Drawing.Point(0, 0);
            this.SideNavTopContent.Name = "SideNavTopContent";
            this.SideNavTopContent.Size = new System.Drawing.Size(230, 173);
            this.SideNavTopContent.TabIndex = 0;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.Location = new System.Drawing.Point(0, 87);
            this.btLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(230, 43);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Connexion/Inscription";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // btAddCat
            // 
            this.btAddCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btAddCat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAddCat.FlatAppearance.BorderSize = 0;
            this.btAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btAddCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAddCat.Location = new System.Drawing.Point(0, 130);
            this.btAddCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.btAddCat.Name = "btAddCat";
            this.btAddCat.Size = new System.Drawing.Size(230, 43);
            this.btAddCat.TabIndex = 1;
            this.btAddCat.Text = "Ajouter une catégorie";
            this.btAddCat.UseVisualStyleBackColor = false;
            this.btAddCat.Click += new System.EventHandler(this.btShowFormCategorie_Click);
            // 
            // Navbar
            // 
            this.Navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.Navbar.Controls.Add(this.SubOptionBox);
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(970, 80);
            this.Navbar.TabIndex = 1;
            this.Navbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Navbar_MouseDown);
            // 
            // SubOptionBox
            // 
            this.SubOptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.SubOptionBox.Controls.Add(this.OptionBox);
            this.SubOptionBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SubOptionBox.Location = new System.Drawing.Point(850, 0);
            this.SubOptionBox.Name = "SubOptionBox";
            this.SubOptionBox.Size = new System.Drawing.Size(120, 80);
            this.SubOptionBox.TabIndex = 0;
            // 
            // OptionBox
            // 
            this.OptionBox.BackColor = System.Drawing.Color.SeaGreen;
            this.OptionBox.Controls.Add(this.minimize);
            this.OptionBox.Controls.Add(this.close);
            this.OptionBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionBox.Location = new System.Drawing.Point(0, 0);
            this.OptionBox.Name = "OptionBox";
            this.OptionBox.Size = new System.Drawing.Size(120, 22);
            this.OptionBox.TabIndex = 0;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("minimize.ErrorImage")));
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.InitialImage = null;
            this.minimize.Location = new System.Drawing.Point(0, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(60, 22);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimize.TabIndex = 2;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseEnter += new System.EventHandler(this.minimize_MouseEnter);
            this.minimize.MouseLeave += new System.EventHandler(this.minimize_MouseLeave);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("close.ErrorImage")));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageLocation = " ";
            this.close.InitialImage = null;
            this.close.Location = new System.Drawing.Point(60, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(60, 22);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_Enter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // displayContent
            // 
            this.displayContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.displayContent.Controls.Add(this.NavBorderBottom);
            this.displayContent.Controls.Add(this.SideNavRightBorder);
            this.displayContent.Controls.Add(this.Navbar);
            this.displayContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.displayContent.Location = new System.Drawing.Point(230, 0);
            this.displayContent.Name = "displayContent";
            this.displayContent.Size = new System.Drawing.Size(970, 700);
            this.displayContent.TabIndex = 2;
            // 
            // NavBorderBottom
            // 
            this.NavBorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.NavBorderBottom.Location = new System.Drawing.Point(3, 75);
            this.NavBorderBottom.Name = "NavBorderBottom";
            this.NavBorderBottom.Size = new System.Drawing.Size(967, 5);
            this.NavBorderBottom.TabIndex = 3;
            // 
            // SideNavRightBorder
            // 
            this.SideNavRightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.SideNavRightBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideNavRightBorder.Location = new System.Drawing.Point(0, 0);
            this.SideNavRightBorder.Name = "SideNavRightBorder";
            this.SideNavRightBorder.Size = new System.Drawing.Size(4, 700);
            this.SideNavRightBorder.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.displayContent);
            this.Controls.Add(this.SideNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SideNav.ResumeLayout(false);
            this.SideNavFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.SideNavTopContent.ResumeLayout(false);
            this.Navbar.ResumeLayout(false);
            this.SubOptionBox.ResumeLayout(false);
            this.OptionBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.displayContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideNav;
        private System.Windows.Forms.Panel SideNavTopContent;
        private System.Windows.Forms.Panel Navbar;
        private System.Windows.Forms.Panel SubOptionBox;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel OptionBox;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btAddCat;
        private System.Windows.Forms.Panel displayContent;
        private System.Windows.Forms.Panel SideNavRightBorder;
        private System.Windows.Forms.Panel NavBorderBottom;
        private System.Windows.Forms.Panel SideNavFooter;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar;
        private System.Windows.Forms.Panel categorieDisplayer;
        private System.Windows.Forms.PictureBox information;
        private System.Windows.Forms.PictureBox settings;
    }
}

