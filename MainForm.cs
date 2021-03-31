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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowaPass
{
    public partial class MainForm : Form
    {
        public static MainForm instance;

        private InformationForm informationForm;
        private CategorieForm categorieForm;
        private Form currentForm = null;
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

        private void btShowFormCategorie_Click(object sender, EventArgs e)
        {
            updateForm();

            categorieForm = new CategorieForm();
            categorieForm.TopLevel = false;
            categorieForm.Dock = DockStyle.Fill;
            categorieForm.BackColor = displayContent.BackColor;

            this.displayContent.Controls.Add(categorieForm);
            categorieForm.Show();

            currentForm = categorieForm;
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
            information.BackColor = Color.FromArgb(11, 19, 43);
        }

        private void information_MouseLeave(object sender, EventArgs e)
        {
            information.BackColor = Color.FromArgb(252, 163, 17);
        }

        private void settings_MouseEnter(object sender, EventArgs e)
        {
            settings.BackColor = Color.FromArgb(11, 19, 43);
        }

        private void settings_MouseLeave(object sender, EventArgs e)
        {
            settings.BackColor = Color.FromArgb(252, 163, 17);
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
    }
}
