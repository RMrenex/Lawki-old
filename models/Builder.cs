using System.Drawing;
using System.Windows.Forms;
using Lawki.forms;

namespace Lawki.models {
    class Builder {

        public static void BuildCategorie(string name) {

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

                MainForm.Instance.UpdateForm();

                ShowCategorieForm showCategorieForm = new ShowCategorieForm();
                showCategorieForm.TopLevel = false;
                showCategorieForm.Dock = DockStyle.Fill;
                showCategorieForm.BackColor = Color.FromArgb(20, 33, 61);

                MainForm.Instance.ShowContent.Controls.Add(showCategorieForm);
                showCategorieForm.Show();
                MainForm.Instance.CurrentForm = showCategorieForm;
                MainForm.Instance.ActiveCategorie = name;

                Category categorie = Category.Categories_.Find(categorie_ => categorie_.Name_.Equals(button.Text));

                if (categorie.Credentials.Count > 0) {
                    categorie.Credentials.ForEach(credential => BuildCredential(showCategorieForm.flow, credential.Label_, credential.Login_, credential.Password_));
                }

            };


            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "picture_" + name;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = new Bitmap(Lawki.Properties.Resources.delete);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.BackColor = Color.FromArgb(11, 19, 43);

            pictureBox.Click += (sender, evt) => { DeleteCategorie(name); };

            MainForm.Instance.PannelCategorieDisplayer.Controls.Add(panel);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(button);
        }


        private static void DeleteCategorie(string name) {

            foreach (Control control in MainForm.Instance.PannelCategorieDisplayer.Controls) {

                if (control is Panel) {

                    if (control.Name.Equals("panel_" + name)) {

                        Panel panelToBeDelete = (Panel)control;
                        MainForm.Instance.PannelCategorieDisplayer.Controls.Remove(control);
                        Category categorieToDelete = Category.Categories_.Find(Categorie => Categorie.Name_.Equals(name));
                        Category.Categories_.Remove(categorieToDelete);

                    }
                }
            }
        }

        public static void BuildCredential(Panel panel, string label, string login, string password) {

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
                Image = new Bitmap(Lawki.Properties.Resources.delete),
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.FromArgb(11, 19, 43)
            };

            pictureBox.MouseEnter += (s, evt) => { pictureBox.Image = new Bitmap(Lawki.Properties.Resources.delete_hover); };
            pictureBox.MouseLeave += (s, evt) => { pictureBox.Image = new Bitmap(Lawki.Properties.Resources.delete); };
            pictureBox.Click += (s, evt) => { DeleteCredential(label, panel, cardPanel); };

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

            textBoxLogin.DoubleClick += (s, evt) => { UpdateLogin(label, textBoxLogin); };
            ShowTooltip(textBoxLogin);

            //Card modify login icon
            PictureBox pictureBoxLogin = new PictureBox() {
                Name = "pictureBoxModifyLogin" + label,
                Dock = DockStyle.Fill,
                Image = new Bitmap(Lawki.Properties.Resources.card_modify),
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.FromArgb(11, 19, 43)
            };

            pictureBoxLogin.MouseEnter += (s, evt) => { pictureBoxLogin.Image = new Bitmap(Lawki.Properties.Resources.card_modify_hover); };
            pictureBoxLogin.MouseLeave += (s, evt) => { pictureBoxLogin.Image = new Bitmap(Lawki.Properties.Resources.card_modify); };
            pictureBoxLogin.Click += (s, evt) => { textBoxLogin.ReadOnly = false; };

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

            textBoxPassword.DoubleClick += (s, evt) => { UpdatePassword(label, textBoxPassword); };
            ShowTooltip(textBoxPassword);

            //Card modify password icon
            PictureBox pictureBoxPassword = new PictureBox() {
                Name = "pictureBoxModifyPassword" + label,
                Dock = DockStyle.Fill,
                Image = new Bitmap(Lawki.Properties.Resources.card_modify),
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.FromArgb(11, 19, 43)
            };

            pictureBoxPassword.MouseEnter += (s, evt) => { pictureBoxPassword.Image = new Bitmap(Lawki.Properties.Resources.card_modify_hover); };
            pictureBoxPassword.MouseLeave += (s, evt) => { pictureBoxPassword.Image = new Bitmap(Lawki.Properties.Resources.card_modify); };
            pictureBoxPassword.Click += (s, evt) => { textBoxPassword.ReadOnly = false; };

            cardPasswordPanel.Controls.Add(pictureBoxPassword);
            cardPasswordPanel.Controls.Add(textBoxPassword);

            panel.Controls.Add(cardPanel);

        }

        private static void DeleteCredential(string name, Panel mainPanel, Panel deletedPanel) {

            Category categorie = Category.Categories_.Find(categorie_ => categorie_.Name_.Equals(MainForm.Instance.ActiveCategorie));
            categorie.Credentials.RemoveAll(credential_ => credential_.Label_.Equals(name));
            mainPanel.Controls.Remove(deletedPanel);
        }

        private static void UpdateLogin(string name, TextBox textBox) {

            if (textBox.ReadOnly == true) {
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox.Text)) {
                return;
            }

            Category categorie = Category.Categories_.Find(categorie_ => categorie_.Name_.Equals(MainForm.Instance.ActiveCategorie));
            Credential credential = categorie.Credentials.Find(credential_ => credential_.Label_.Equals(name));
            credential.Login_ = textBox.Text;

            textBox.Name = "textBoxLogin" + textBox.Name;
            textBox.ReadOnly = true;     
        }

        private static void UpdatePassword(string name, TextBox textBox) {

            if (textBox.ReadOnly == true) {
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox.Text)) {
                return;
            }

            Category categorie = Category.Categories_.Find(categorie_ => categorie_.Name_.Equals(MainForm.Instance.ActiveCategorie));
            Credential credential = categorie.Credentials.Find(credential_ => credential_.Label_.Equals(name));
            credential.Password_ = textBox.Text;

            textBox.Name = "textBoxPassword" + textBox.Name;
            textBox.ReadOnly = true;
        }

        private static void ShowTooltip(TextBox textBox) {

            MetroFramework.Components.MetroToolTip toolTip = new MetroFramework.Components.MetroToolTip() {
                AutoPopDelay = 5000,
                InitialDelay = 0,
                ReshowDelay = 0,
                ShowAlways = true
            };

            toolTip.SetToolTip(textBox, Program.Fields["showCategorieForm_tooltips_credential"]);
        }
    }
}
