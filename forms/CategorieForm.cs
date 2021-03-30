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
    public partial class CategorieForm : Form
    {

        public CategorieForm()
        {
            InitializeComponent();
            this.inputPassword.AutoSize = false;
            this.inputPassword.Size = new System.Drawing.Size(200, 30);
            this.inputLogin.AutoSize = false;
            this.inputLogin.Size = new System.Drawing.Size(200, 30);

            this.btValideCategorie.ForeColor = Color.FromArgb(252, 163, 17);
            this.btValideCategorie.Font = new Font(btValideCategorie.Font.Name, btValideCategorie.Font.Size, FontStyle.Bold);
        }

        private void btValideCategorie_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            //button.FlatAppearance.BorderColor = Color.FromArgb(252, 163, 17);
            button.Dock = DockStyle.Top;
            button.BackColor = Color.FromArgb(11, 19, 43);
            button.Height = 50;

            MainForm.instance.pannelCategorieDisplayer.Controls.Add(button);
            passwordSecurityThreshold(inputPassword.Text);
        }

        private void passwordSecurityThreshold(String password) {

            var expectedPasswordPattern = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,15}$");
            var isValidPassword = expectedPasswordPattern.IsMatch(password);

            if (!isValidPassword) {
                labelWarning.Visible = true;
            }

            System.Diagnostics.Debug.WriteLine(isValidPassword);
        }
    }
}
