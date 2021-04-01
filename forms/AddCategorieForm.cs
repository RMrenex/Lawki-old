using LowaPasswd.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowaPass
{
    public partial class AddCategorieForm : Form
    {

        public AddCategorieForm()
        {
            InitializeComponent();
            this.inputPassword.AutoSize = false;
            this.inputPassword.Size = new System.Drawing.Size(200, 30);
            this.inputLogin.AutoSize = false;
            this.inputLogin.Size = new System.Drawing.Size(200, 30);

            this.btValideCategorie.ForeColor = Color.FromArgb(252, 163, 17);
            this.btValideCategorie.Font = new Font(btValideCategorie.Font.Name, btValideCategorie.Font.Size, FontStyle.Bold);
        }

        private void addCategorie_Click(object sender, EventArgs e)
        {

            if (inputLogin.Text == "" || inputPassword.Text == "")
            {
                labelWarning.Text = "Erreur : Identifiant ou mot de passe non saisie.";
                labelWarning.Visible = true;
                hideWarning(3000);
                return;
            }

            if (!passwordSecurityThreshold(inputPassword.Text)) {

                labelWarning.Text = "Attention : Pour plus de sécurité votre mot de passe doit contenir au minimum une majuscule des chiffres et des caractères alpha numériques. De plus il est préférable que celui-ci soit compris entre 8 et 15 caractères.";
                labelWarning.Visible = true;
                hideWarning(10000);
            }

            if (Categorie.Categories_.Find(categorie => categorie.Name_ == inputLogin.Text) != null)
            {

                labelWarning.Text = "Erreur : Ce nom de catégorie est déjà utilisé";
                labelWarning.Visible = true;
                hideWarning(5000);
                return;

            }

            Button button = new Button();
            button.Text = inputLogin.Text;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Dock = DockStyle.Top;
            button.BackColor = Color.FromArgb(11, 19, 43);
            button.Height = 50;

            MainForm.instance.pannelCategorieDisplayer.Controls.Add(button);
            Categorie.Categories_.Add(new Categorie(inputLogin.Text, new List<Credential>()));

            inputLogin.ResetText();
            inputPassword.ResetText();
        }

        private Boolean passwordSecurityThreshold(string password) {

            var expectedPasswordPattern = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,15}$");
            var isValidPassword = expectedPasswordPattern.IsMatch(password);

            if (!isValidPassword) {
                return false;
            }

            return true;

        }

        private void hideWarning(int longTime) {

            var timer = new Timer();
            timer.Interval = longTime;

            timer.Tick += (s, e) =>
            {
                labelWarning.Hide();
                timer.Stop();
            };

            timer.Start();
        }
    }
}
