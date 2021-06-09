using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Lawki.forms;
using Lawki.models;

namespace Lawki {
    public partial class MainForm : Form
    {
        public static MainForm Instance;
        private InformationForm _informationForm;
        private SettingsForm _settingsForm;
        public Form CurrentForm = null;
        public Panel PannelCategorieDisplayer;
        public Panel ShowContent;
        private const int WmNclbuttondown = 0xA1;
        private const int HtCaption = 0x2;
        private string _activeCategorie = null;

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
            Instance = this;
            labelAddCategorie.Text = Program.Fields["mainForm_add_category"];
            PannelCategorieDisplayer = categorieDisplayer;
            ShowContent = displayContent;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            metroScrollBar.Scroll += (sender, e) => { categorieDisplayer.VerticalScroll.Value = metroScrollBar.Value; };

            if (Category.Categories_.Count != 0) {
                Category.Categories_.ForEach(category => Builder.BuildCategorie(category.Name_));
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            FileManager.WriteInFile();
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
                SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
            }
        }


        private void information_MouseEnter(object sender, EventArgs e)
        {
            information.Image = new Bitmap(Lawki.Properties.Resources.information);
        }

        private void information_MouseLeave(object sender, EventArgs e)
        {
            information.Image = new Bitmap(Lawki.Properties.Resources.information_hover);
        }

        private void settings_MouseEnter(object sender, EventArgs e)
        {
            settings.Image = new Bitmap(Lawki.Properties.Resources.settings);
        }

        private void settings_MouseLeave(object sender, EventArgs e)
        {
            settings.Image = new Bitmap(Lawki.Properties.Resources.settings_hover);
        }

        private void information_Click(object sender, EventArgs e)
        {
            UpdateForm();

            _informationForm = new InformationForm();
            _informationForm.TopLevel = false;
            _informationForm.Dock = DockStyle.Fill;
            _informationForm.BackColor = displayContent.BackColor;

            this.displayContent.Controls.Add(_informationForm);
            _informationForm.Show();
            CurrentForm = _informationForm;
        }

        private void settings_Click(object sender, EventArgs e) {

            UpdateForm();

            _settingsForm = new SettingsForm(labelAddCategorie);
            _settingsForm.TopLevel = false;
            _settingsForm.Dock = DockStyle.Fill;
            _settingsForm.BackColor = displayContent.BackColor;

            this.displayContent.Controls.Add(_settingsForm);
            _settingsForm.Show();
            CurrentForm = _settingsForm;
        }

        public void UpdateForm() {

            if (CurrentForm != null) {
                this.displayContent.Controls.Remove(CurrentForm);
            }
        }

        private void addCategorieButton_MouseEnter(object sender, EventArgs e)
        {
            addCategorieButton.Image = new Bitmap(Lawki.Properties.Resources.add_categorie);
        }

        private void addCategorieButton_MouseLeave(object sender, EventArgs e)
        {
            addCategorieButton.Image = new Bitmap(Lawki.Properties.Resources.add_categorie_hover);
        }

        private void addCategorieButton_Click(object sender, EventArgs e)
        {

            if (inputAddCategorieButton.Lines.Length > 1) {
                Notification notification = new Notification("Erreur : vous ne pouvez pas écrire sur plusieurs lignes");
                notification.Show();
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }

            else if (string.IsNullOrWhiteSpace(inputAddCategorieButton.Text)) {
                Notification notification = new Notification("Erreur: La catégorie ne peux pas être vide");
                notification.Show();
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }

            else if (Category.Categories_.Find(categorie => categorie.Name_.ToUpper().Equals(inputAddCategorieButton.Text.ToUpper())) != null){
                Notification notification = new Notification("Erreur : Ce nom de catégorie est déjà utilisé");
                notification.Show();
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }

            Category.Categories_.Add(new Category(inputAddCategorieButton.Text, new List<Credential>()));
            Builder.BuildCategorie(inputAddCategorieButton.Text);
            inputAddCategorieButton.ResetText();

        }

        private void AddCategorieButton_KeyPress(object sender, KeyPressEventArgs e) {

            if (e.KeyChar == (char)13) {
                addCategorieButton_Click(sender, e);
            }

        }

        public string ActiveCategorie { get => _activeCategorie; set => _activeCategorie = value; }
    }
}
