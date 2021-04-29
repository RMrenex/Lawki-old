using LowaPass;
using LowaPasswd.forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowaPasswd.models {
    class Builder {

        public static void buildCategorie(string name) {

            Panel panel = new Panel() {
                Name = "panel_" + name,
                Dock = DockStyle.Top,
                Height = 50
            };

            Button button = new Button();
            button.Name = "bt_" + name;
            button.Text = name;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Dock = DockStyle.Left;
            button.BackColor = Color.FromArgb(11, 19, 43);
            button.Width = 180;

            button.Click += (sender, evt) => {

                MainForm.instance.updateForm();

                ShowCategorieForm showCategorieForm = new ShowCategorieForm();
                showCategorieForm.TopLevel = false;
                showCategorieForm.Dock = DockStyle.Fill;
                showCategorieForm.BackColor = Color.FromArgb(20, 33, 61);

                MainForm.instance.showContent.Controls.Add(showCategorieForm);
                showCategorieForm.Show();
                MainForm.instance.currentForm = showCategorieForm;
                MainForm.instance.ActiveCategorie = name;

                Categorie categorie = Categorie.Categories_.Find(categorie_ => categorie_.Name_.Equals(button.Text));

                if (categorie.Credentials_.Count > 0) {
                    categorie.Credentials_.ForEach(credential => buildCredential(showCategorieForm.flow, credential.Label_, credential.Login_, credential.Password_));
                }

            };


            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "picture_" + name;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = new Bitmap(LowaPasswd.Properties.Resources.delete);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.BackColor = Color.FromArgb(11, 19, 43);

            pictureBox.Click += (sender, evt) => { deleteCategorie(name); };

            MainForm.instance.pannelCategorieDisplayer.Controls.Add(panel);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(button);
        }


        private static void deleteCategorie(string name) {

            foreach (Control control in MainForm.instance.pannelCategorieDisplayer.Controls) {

                if (control is Panel) {

                    if (control.Name.Equals("panel_" + name)) {

                        Panel panelToBeDelete = (Panel)control;
                        MainForm.instance.pannelCategorieDisplayer.Controls.Remove(control);
                        Categorie categorieToDelete = Categorie.Categories_.Find(Categorie => Categorie.Name_.Equals(name));
                        Categorie.Categories_.Remove(categorieToDelete);

                    }
                }

            }

        }

        public static void buildCredential(Panel panel, string label, string login, string password) {

            //Card-panel
            Panel cardPanel = new Panel() {
                MinimumSize = new Size(475, 150),
                BackColor = Color.FromArgb(11, 19, 43),
                Name = "cardPanel" + label
            };

            //Card-Title-Panel
            Panel cardTitlePanel = new Panel() {
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(252, 163, 17),
                Name = "cardTitlePanel" + label,
                Height = 50
            };

            //Card-Input-Login
            Panel cardLoginPanel = new Panel() {
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(11, 19, 43),
                Name = "cardLoginPanel" + label,
                Height = 50
            };
            //Card-Input-Password
            Panel cardPasswordPanel = new Panel() {
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(11, 19, 43),
                Name = "cardPasswordPanel" + label,
                Height = 50
            };

            //Add sub panel to main panel
            cardPanel.Controls.Add(cardPasswordPanel);//third line
            cardPanel.Controls.Add(cardLoginPanel); //second line
            cardPanel.Controls.Add(cardTitlePanel); //First line

            //Card title label
            Label cardTitle = new Label() {
                Name = "cardTitle" + label,
                Text = label.ToUpper(),
                Dock = DockStyle.Left,
                Width = 430,
                BorderStyle = BorderStyle.None,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(252, 163, 17),
                Font = new Font("Arial", 14),
                AutoSize = false
            };

            //Card delete icon
            PictureBox pictureBox = new PictureBox() {
                Name = "pictureBoxDelete" + label,
                Dock = DockStyle.Fill,
                Image = new Bitmap(LowaPasswd.Properties.Resources.delete),
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.FromArgb(11, 19, 43)
            };

            pictureBox.MouseEnter += (s, evt) => { pictureBox.Image = new Bitmap(LowaPasswd.Properties.Resources.delete_hover); };
            pictureBox.MouseLeave += (s, evt) => { pictureBox.Image = new Bitmap(LowaPasswd.Properties.Resources.delete); };

            //Add first sub line 
            cardTitlePanel.Controls.Add(pictureBox);
            cardTitlePanel.Controls.Add(cardTitle);


            //Card login input
            TextBox textBoxLogin = new TextBox() {
                Name = "textBoxLogin" + label,
                Dock = DockStyle.Left,
                BackColor = Color.FromArgb(11, 19, 43),
                Font = new Font("Arial", 14),
                ForeColor = Color.FromArgb(252, 163, 17),
                Text = login,
                ReadOnly = true,
                Multiline = true,
                TextAlign = HorizontalAlignment.Center,
                Width = 430,
                BorderStyle = BorderStyle.None
            };

            //Card delete icon
            PictureBox pictureBoxLogin = new PictureBox() {
                Name = "pictureBoxModifyLogin" + label,
                Dock = DockStyle.Fill,
                Image = new Bitmap(LowaPasswd.Properties.Resources.card_modify),
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.FromArgb(11, 19, 43)
            };

            pictureBoxLogin.MouseEnter += (s, evt) => { pictureBoxLogin.Image = new Bitmap(LowaPasswd.Properties.Resources.card_modify_hover); };
            pictureBoxLogin.MouseLeave += (s, evt) => { pictureBoxLogin.Image = new Bitmap(LowaPasswd.Properties.Resources.card_modify); };

            //Add second sub line
            cardLoginPanel.Controls.Add(pictureBoxLogin);
            cardLoginPanel.Controls.Add(textBoxLogin);

            //Card password input
            TextBox textBoxPassword = new TextBox() {
                Name = "textBoxPassword" + label,
                Dock = DockStyle.Left,
                BackColor = Color.FromArgb(11, 19, 43),
                Font = new Font("Arial", 14),
                ForeColor = Color.FromArgb(252, 163, 17),
                Text = password,
                ReadOnly = true,
                Multiline = true,
                TextAlign = HorizontalAlignment.Center,
                Width = 430,
                BorderStyle = BorderStyle.None,
                UseSystemPasswordChar = true,
                PasswordChar = '*'
            };

            //Card modify password icon
            PictureBox pictureBoxPassword = new PictureBox() {
                Name = "pictureBoxModifyPassword" + label,
                Dock = DockStyle.Fill,
                Image = new Bitmap(LowaPasswd.Properties.Resources.card_modify),
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.FromArgb(11, 19, 43)
            };

            pictureBoxPassword.MouseEnter += (s, evt) => { pictureBoxPassword.Image = new Bitmap(LowaPasswd.Properties.Resources.card_modify_hover); };
            pictureBoxPassword.MouseLeave += (s, evt) => { pictureBoxPassword.Image = new Bitmap(LowaPasswd.Properties.Resources.card_modify); };

            cardPasswordPanel.Controls.Add(pictureBoxPassword);
            cardPasswordPanel.Controls.Add(textBoxPassword);

            panel.Controls.Add(cardPanel);

        }
    }
}
