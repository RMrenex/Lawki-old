using System;
using System.Windows.Forms;

namespace LowaPass.Forms {
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void buttonSearchFile_Click(object sender, EventArgs e) {

            using (var fbd = new FolderBrowserDialog()) {

                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    inputFileSetup.Text = fbd.SelectedPath;
                }
            }

        }

        private void buttonSaveChanged_Click(object sender, EventArgs e) {

        }
    }
}
