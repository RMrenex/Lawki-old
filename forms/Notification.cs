using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lawki.forms {
    public partial class Notification : Form {

        public Notification() {
            InitializeComponent();
        }

        public Notification(string message) {
            InitializeComponent();
            labelNotificationtext.Text = message;
        }

        private void buttonNotification_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonNotification_MouseEnter(object sender, EventArgs e) {
            buttonNotification.BackColor = Color.FromArgb(252, 163, 17);
            buttonNotification.ForeColor = Color.FromArgb(11, 19, 43);
        }

        private void buttonNotification_MouseLeave(object sender, EventArgs e) {
            buttonNotification.BackColor = Color.FromArgb(11, 19, 43);
            buttonNotification.ForeColor = Color.FromArgb(252, 163, 17);
        }
    }
}
