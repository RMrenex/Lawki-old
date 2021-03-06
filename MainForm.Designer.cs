
namespace Lawki
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
            this.SideNav = new System.Windows.Forms.Panel();
            this.categorieDisplayer = new System.Windows.Forms.Panel();
            this.metroScrollBar = new MetroFramework.Controls.MetroScrollBar();
            this.SideNavFooter = new System.Windows.Forms.Panel();
            this.information = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.SideNavTopContent = new System.Windows.Forms.Panel();
            this.Navbar = new System.Windows.Forms.Panel();
            this.SubOptionBox = new System.Windows.Forms.Panel();
            this.OptionBox = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.displayContent = new System.Windows.Forms.Panel();
            this.bottomPanelAddCategorie = new System.Windows.Forms.Panel();
            this.labelAddCategorie = new System.Windows.Forms.Label();
            this.addCategorieButton = new System.Windows.Forms.PictureBox();
            this.inputAddCategorieButton = new System.Windows.Forms.TextBox();
            this.NavBorderBottom = new System.Windows.Forms.Panel();
            this.SideNavRightBorder = new System.Windows.Forms.Panel();
            this.SideNav.SuspendLayout();
            this.SideNavFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.Navbar.SuspendLayout();
            this.SubOptionBox.SuspendLayout();
            this.OptionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.displayContent.SuspendLayout();
            this.bottomPanelAddCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCategorieButton)).BeginInit();
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
            this.information.Image = global::Lawki.Properties.Resources.information_hover;
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
            this.settings.Image = global::Lawki.Properties.Resources.settings_hover;
            this.settings.Location = new System.Drawing.Point(0, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(59, 50);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.settings.TabIndex = 0;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            this.settings.MouseEnter += new System.EventHandler(this.settings_MouseEnter);
            this.settings.MouseLeave += new System.EventHandler(this.settings_MouseLeave);
            // 
            // SideNavTopContent
            // 
            this.SideNavTopContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.SideNavTopContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.SideNavTopContent.Location = new System.Drawing.Point(0, 0);
            this.SideNavTopContent.Name = "SideNavTopContent";
            this.SideNavTopContent.Size = new System.Drawing.Size(230, 173);
            this.SideNavTopContent.TabIndex = 0;
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
            this.minimize.ErrorImage = global::Lawki.Properties.Resources.line;
            this.minimize.Image = global::Lawki.Properties.Resources.line;
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
            this.close.ErrorImage = global::Lawki.Properties.Resources.close;
            this.close.Image = global::Lawki.Properties.Resources.close;
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
            this.displayContent.Controls.Add(this.bottomPanelAddCategorie);
            this.displayContent.Controls.Add(this.NavBorderBottom);
            this.displayContent.Controls.Add(this.SideNavRightBorder);
            this.displayContent.Controls.Add(this.Navbar);
            this.displayContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.displayContent.Location = new System.Drawing.Point(230, 0);
            this.displayContent.Name = "displayContent";
            this.displayContent.Size = new System.Drawing.Size(970, 700);
            this.displayContent.TabIndex = 2;
            // 
            // bottomPanelAddCategorie
            // 
            this.bottomPanelAddCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.bottomPanelAddCategorie.Controls.Add(this.labelAddCategorie);
            this.bottomPanelAddCategorie.Controls.Add(this.addCategorieButton);
            this.bottomPanelAddCategorie.Controls.Add(this.inputAddCategorieButton);
            this.bottomPanelAddCategorie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanelAddCategorie.Location = new System.Drawing.Point(4, 650);
            this.bottomPanelAddCategorie.Name = "bottomPanelAddCategorie";
            this.bottomPanelAddCategorie.Size = new System.Drawing.Size(966, 50);
            this.bottomPanelAddCategorie.TabIndex = 4;
            // 
            // labelAddCategorie
            // 
            this.labelAddCategorie.BackColor = System.Drawing.Color.Transparent;
            this.labelAddCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAddCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.labelAddCategorie.Location = new System.Drawing.Point(121, 3);
            this.labelAddCategorie.Name = "labelAddCategorie";
            this.labelAddCategorie.Size = new System.Drawing.Size(255, 44);
            this.labelAddCategorie.TabIndex = 2;
            this.labelAddCategorie.Text = "AJOUTER UNE CATEGORIE";
            this.labelAddCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addCategorieButton
            // 
            this.addCategorieButton.Image = global::Lawki.Properties.Resources.add_categorie_hover;
            this.addCategorieButton.Location = new System.Drawing.Point(642, 3);
            this.addCategorieButton.Name = "addCategorieButton";
            this.addCategorieButton.Size = new System.Drawing.Size(44, 44);
            this.addCategorieButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addCategorieButton.TabIndex = 1;
            this.addCategorieButton.TabStop = false;
            this.addCategorieButton.Click += new System.EventHandler(this.addCategorieButton_Click);
            this.addCategorieButton.MouseEnter += new System.EventHandler(this.addCategorieButton_MouseEnter);
            this.addCategorieButton.MouseLeave += new System.EventHandler(this.addCategorieButton_MouseLeave);
            // 
            // inputAddCategorieButton
            // 
            this.inputAddCategorieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.inputAddCategorieButton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAddCategorieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAddCategorieButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.inputAddCategorieButton.Location = new System.Drawing.Point(382, 8);
            this.inputAddCategorieButton.Multiline = true;
            this.inputAddCategorieButton.Name = "inputAddCategorieButton";
            this.inputAddCategorieButton.Size = new System.Drawing.Size(254, 35);
            this.inputAddCategorieButton.TabIndex = 0;
            this.inputAddCategorieButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddCategorieButton_KeyPress);
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
            this.Navbar.ResumeLayout(false);
            this.SubOptionBox.ResumeLayout(false);
            this.OptionBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.displayContent.ResumeLayout(false);
            this.bottomPanelAddCategorie.ResumeLayout(false);
            this.bottomPanelAddCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCategorieButton)).EndInit();
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
        private System.Windows.Forms.Panel displayContent;
        private System.Windows.Forms.Panel SideNavRightBorder;
        private System.Windows.Forms.Panel NavBorderBottom;
        private System.Windows.Forms.Panel SideNavFooter;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar;
        private System.Windows.Forms.Panel categorieDisplayer;
        private System.Windows.Forms.PictureBox information;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.Panel bottomPanelAddCategorie;
        private System.Windows.Forms.TextBox inputAddCategorieButton;
        private System.Windows.Forms.PictureBox addCategorieButton;
        private System.Windows.Forms.Label labelAddCategorie;
    }
}

