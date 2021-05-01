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
                labelWarning.Text = "Erreur : vous ne pouvez pas écrire sur plusieurs lignes";
                labelWarning.Visible = true;
                hideWarning(3000);
                return;
            }

            if (string.IsNullOrWhiteSpace(inputAddCredentialName.Text) || string.IsNullOrWhiteSpace(inputaddCredentialLogin.Text) || string.IsNullOrWhiteSpace(inputaddCredentialPassword.Text)) {
                labelWarning.Text = "Erreur : Un ou plusieurs champs sont vides";
                labelWarning.Visible = true;
                hideWarning(3000);
                return;
            }

            Categorie categorie = Categorie.Categories_.Find(categorie_ => categorie_.Name_.Equals(MainForm.instance.ActiveCategorie));
            bool exist = categorie.Credentials_.Exists(credential => credential.Label_.ToUpper().Equals(inputAddCredentialName.Text.ToUpper()));

            if (!exist) {
                Builder.buildCredential(flowLayoutPanel, inputAddCredentialName.Text, inputaddCredentialLogin.Text, inputaddCredentialPassword.Text);
                categorie.Credentials_.Add(new Credential(inputAddCredentialName.Text, inputaddCredentialLogin.Text, inputaddCredentialPassword.Text));
            }
            else {
                labelWarning.Text = "Erreur : Ce nom est déjà utilisé";
                labelWarning.Visible = true;
                hideWarning(3000);
            }

            inputAddCredentialName.Clear();
            inputaddCredentialLogin.Clear();
            inputaddCredentialPassword.Clear();
        }

        private Boolean passwordSecurityThreshold(string password) {

            var expectedPasswordPattern = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,15}$");
            var isValidPassword = expectedPasswordPattern.IsMatch(password);

            if (!isValidPassword) {
                return false;
            }

            return true;
        }

        public void hideWarning(int longTime) {

            var timer = new Timer();
            timer.Interval = longTime;

            timer.Tick += (s, e) => {
                labelWarning.Hide();
                timer.Stop();
            };

            timer.Start();
        }

        private void pictureBoxAddCredential_MouseEnter(object sender, EventArgs e) {

            pictureBoxAddCredential.Image = new Bitmap(LowaPasswd.Properties.Resources.add_credential_hover);

        }

        private void pictureBoxAddCredential_MouseLeave(object sender, EventArgs e) {
            pictureBoxAddCredential.Image = new Bitmap(LowaPasswd.Properties.Resources.add_credential);

        }
    }
}
