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
            labelAddName.Text = Program.Fields["showCategorieForm_name_add_credential"];
            labelAddLogin.Text = Program.Fields["showCategorieForm_login_add_credential"];
            labelAddPassword.Text = Program.Fields["showCategorieForm_password_add_credential"];

            if (Category.Categories_.Count != 0)
            {
                //Category.Categories_.ForEach(category => category.Credentials.ForEach(credential => Builder.BuildCredential(flow, credential.Label_, credential.Login_, credential.Password_)));
            }
        }

        private void pictureBoxAddCredential_Click(object sender, EventArgs e) {

            if (inputAddCredentialName.Lines.Length > 1 || inputaddCredentialLogin.Lines.Length > 1 || inputaddCredentialPassword.Lines.Length > 1 ) {
                Notification notification = new Notification(Program.Fields["error_multi_lines"]);
                notification.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(inputAddCredentialName.Text) || string.IsNullOrWhiteSpace(inputaddCredentialLogin.Text) || string.IsNullOrWhiteSpace(inputaddCredentialPassword.Text)) {
                Notification notification = new Notification(Program.Fields["error_empty_field"]);
                notification.Show();
                return;
            }

            Category categorie = Category.Categories_.Find(categorie_ => categorie_.Name_.Equals(MainForm.Instance.ActiveCategorie));
            bool exist = categorie.Credentials.Exists(credential => credential.Label_.ToUpper().Equals(inputAddCredentialName.Text.ToUpper()));

            if (!exist) {
                Builder.BuildCredential(flowLayoutPanel, inputAddCredentialName.Text, inputaddCredentialLogin.Text, inputaddCredentialPassword.Text);
                categorie.Credentials.Add(new Credential(inputAddCredentialName.Text, inputaddCredentialLogin.Text, inputaddCredentialPassword.Text));
            }
            else {
                Notification notification = new Notification(Program.Fields["error_name_already_use"]);
                notification.Show();
            }

            inputAddCredentialName.Clear();
            inputaddCredentialLogin.Clear();
            inputaddCredentialPassword.Clear();
        }

        private bool PasswordSecurityThreshold(string password) {

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
