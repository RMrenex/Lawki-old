using LowaPasswd.forms;
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
    public partial class MainForm : Form
    {
        public static MainForm instance;

        private InformationForm informationForm;
        public Form currentForm = null;
        public Panel pannelCategorieDisplayer;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public MainForm()
        {
            InitializeComponent();
            instance = this;
            pannelCategorieDisplayer = categorieDisplayer;
            this.categorieDisplayer.Paint += new PaintEventHandler(this.categorieDisplayer_Paint);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            metroScrollBar.Scroll += (sender, e) => { categorieDisplayer.VerticalScroll.Value = metroScrollBar.Value; };
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_Enter(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(11, 19, 43);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(20, 33, 61);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            minimize.BackColor = Color.FromArgb(11, 19, 43);
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackColor = Color.FromArgb(20, 33, 61);
        }

        private void Navbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void categorieDisplayer_Paint(object sender, PaintEventArgs e)
        {

            ControlPaint.DrawBorder(e.Graphics, this.categorieDisplayer.ClientRectangle, Color.Transparent, 0, ButtonBorderStyle.None,
               Color.FromArgb(252, 163, 17), 1, ButtonBorderStyle.Solid, Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None);
        }

        private void information_MouseEnter(object sender, EventArgs e)
        {
            information.Image = Image.FromFile("C:/Users/Steven/source/repos/LowaPasswd/icons/information_hover.png");
        }

        private void information_MouseLeave(object sender, EventArgs e)
        {
            information.Image = Image.FromFile("C:/Users/Steven/source/repos/LowaPasswd/icons/information.png");
        }

        private void settings_MouseEnter(object sender, EventArgs e)
        {
            settings.Image = Image.FromFile("C:/Users/Steven/source/repos/LowaPasswd/icons/settings_hover.png");
        }

        private void settings_MouseLeave(object sender, EventArgs e)
        {
            settings.Image = Image.FromFile("C:/Users/Steven/source/repos/LowaPasswd/icons/settings.png");
        }

        private void information_Click(object sender, EventArgs e)
        {
            updateForm();

            informationForm = new InformationForm();
            informationForm.TopLevel = false;
            informationForm.Dock = DockStyle.Fill;
            informationForm.BackColor = displayContent.BackColor;

            this.displayContent.Controls.Add(informationForm);
            informationForm.Show();

            currentForm = informationForm;
        }

        private void updateForm() {

            if (currentForm != null) {
                this.displayContent.Controls.Remove(currentForm);
            }
        }

        private void hideWarning(int longTime){

            var timer = new Timer();
            timer.Interval = longTime;

            timer.Tick += (s, e) =>
            {
                labelWarning.Hide();
                timer.Stop();
            };

            timer.Start();
        }

        private Boolean passwordSecurityThreshold(string password)
        {

            var expectedPasswordPattern = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,15}$");
            var isValidPassword = expectedPasswordPattern.IsMatch(password);

            if (!isValidPassword)
            {
                return false;
            }

            return true;
        }

        private void addCategorieButton_MouseEnter(object sender, EventArgs e)
        {
            addCategorieButton.Image = Image.FromFile("C:/Users/Steven/source/repos/LowaPasswd/icons/add_categorie_hover.png");
        }

        private void addCategorieButton_MouseLeave(object sender, EventArgs e)
        {
            addCategorieButton.Image = Image.FromFile("C:/Users/Steven/source/repos/LowaPasswd/icons/add_categorie.png");
        }

        private void addCategorieButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(inputAddCategorieButton.Text)) {
                labelWarning.Text = "Erreur : La catégorie ne peux pas être vide";
                labelWarning.Visible = true;
                hideWarning(3000);
                return;
            }

            if (Categorie.Categories_.Find(categorie => categorie.Name_ == inputAddCategorieButton.Text) != null)
            {

                labelWarning.Text = "Erreur : Ce nom de catégorie est déjà utilisé";
                labelWarning.Visible = true;
                hideWarning(5000);
                return;
            }

            Button button = new Button();
            button.Text = inputAddCategorieButton.Text;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Dock = DockStyle.Top;
            button.BackColor = Color.FromArgb(11, 19, 43);
            button.Height = 50;

            button.Click += (s, evt) => {

                updateForm();

                ShowCategorieForm showCategorieForm = new ShowCategorieForm();
                showCategorieForm.TopLevel = false;
                showCategorieForm.Dock = DockStyle.Fill;
                showCategorieForm.BackColor = displayContent.BackColor;

                displayContent.Controls.Add(showCategorieForm);
                showCategorieForm.Show();

                currentForm = showCategorieForm;

                //Categorie categorie = (Categorie)Categorie.Categories_.Select(categorie_ => categorie_.Name_.Equals(button.Text));
                //categorie.Credentials_.ForEach(credential => { });

            };

            buildCategorie(inputAddCategorieButton.Text);
            Categorie.Categories_.Add(new Categorie(inputAddCategorieButton.Text, new List<Credential>()));
            inputAddCategorieButton.ResetText();

        }

        private void buildCategorie(string name) {

            Panel panel = new Panel()
            {
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

            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "picture_" + name;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Image.FromFile("C:/Users/Steven/source/repos/LowaPasswd/icons/delete.png");
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            categorieDisplayer.Controls.Add(panel);
            panel.Controls.Add(button);
            panel.Controls.Add(pictureBox);

        }
    }
}
