using LowaPass;
using LowaPasswd.models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LowaPasswd.forms {
    public partial class ShowCategorieForm : Form

    {
        public FlowLayoutPanel flow;
        public ShowCategorieForm()
        {
            InitializeComponent();
            flow = flowLayoutPanel;
        }

        private void pictureBoxAddCredential_Click(object sender, EventArgs e) {

            if (inputAddCredentialName.Lines.Length > 1 || inputaddCredentialLogin.Lines.Length > 1 || inputaddCredentialPassword.Lines.Length > 1 ) {
                Notification notification = new Notification("Erreur : vous ne pouvez pas écrire sur plusieurs lignes");
                notification.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(inputAddCredentialName.Text) || string.IsNullOrWhiteSpace(inputaddCredentialLogin.Text) || string.IsNullOrWhiteSpace(inputaddCredentialPassword.Text)) {
                Notification notification = new Notification("Erreur : Un ou plusieurs champs sont vides");
                notification.Show();
                return;
            }

            Categorie categorie = Categorie.Categories_.Find(categorie_ => categorie_.Name_.Equals(MainForm.instance.ActiveCategorie));
            bool exist = categorie.Credentials_.Exists(credential => credential.Label_.ToUpper().Equals(inputAddCredentialName.Text.ToUpper()));

            if (!exist) {
                Builder.buildCredential(flowLayoutPanel, inputAddCredentialName.Text, inputaddCredentialLogin.Text, inputaddCredentialPassword.Text);
                categorie.Credentials_.Add(new Credential(inputAddCredentialName.Text, inputaddCredentialLogin.Text, inputaddCredentialPassword.Text));
            }
            else {
                Notification notification = new Notification("Erreur : Ce nom est déjà utilisé");
                notification.Show();
            }

            inputAddCredentialName.Clear();
            inputaddCredentialLogin.Clear();
            inputaddCredentialPassword.Clear();
        }

        private bool passwordSecurityThreshold(string password) {

            var expectedPasswordPattern = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,15}$");
            var isValidPassword = expectedPasswordPattern.IsMatch(password);

            if (!isValidPassword) {
                return false;
            }

            return true;
        }

        private void pictureBoxAddCredential_MouseEnter(object sender, EventArgs e) {

            pictureBoxAddCredential.Image = new Bitmap(LowaPasswd.Properties.Resources.add_credential_hover);

        }

        private void pictureBoxAddCredential_MouseLeave(object sender, EventArgs e) {
            pictureBoxAddCredential.Image = new Bitmap(LowaPasswd.Properties.Resources.add_credential);

        }
    }
}
