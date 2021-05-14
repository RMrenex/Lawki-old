using LowaPasswd;
using LowaPasswd.models;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LowaPass.Forms {
    public partial class SettingsForm : Form
    {

        private Label labelAddCategorie;
        public SettingsForm(Label labelAddCategorie)
        {
            InitializeComponent();
            updateUI(false);
            this.labelAddCategorie = labelAddCategorie;

            if (ConfigurationManager.AppSettings.Get("lang").Equals("fr")) {
                comboBoxLang.SelectedItem = "Francais/French";
            }
            else if (ConfigurationManager.AppSettings.Get("lang").Equals("en")) {
                comboBoxLang.SelectedItem = "Anglais/English";
            }

            foreach (string item in comboBoxTheme.Items) {

                if (item.ToUpper().Contains(ConfigurationManager.AppSettings.Get("theme").ToUpper())) {
                    comboBoxTheme.SelectedItem = item;
                }
            }
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

            if (!comboBoxLang.Text.Equals(ConfigurationManager.AppSettings.Get("lang"))) {

                if (comboBoxLang.Text.Equals("Francais/French")) {
                    Console.WriteLine("FR");
                    Program.Lang_file = XDocument.Load(FileManager.applicationDirectoryPath + "/lang/Fr.xml");
                    Program.Fields.Clear();
                    Program.Fields = Program.Lang_file.Descendants("add").ToDictionary(key => key.Attribute("key").Value, value => value.Attribute("value").Value);
                }
                else if (comboBoxLang.Text.Equals("Anglais/English")) {
                    Console.WriteLine("EN");
                    Program.Lang_file = XDocument.Load(FileManager.applicationDirectoryPath + "/lang/En.xml");
                    Program.Fields.Clear();
                    Program.Fields = Program.Lang_file.Descendants("add").ToDictionary(key => key.Attribute("key").Value, value => value.Attribute("value").Value);
                }
            }

            updateUI(true);

        }

        private void updateUI(bool force) {

            if (force) {
                labelAddCategorie.Text = Program.Fields["mainForm_add_category"];
            }

            inputFileSetup.Text = Program.Directory;
            labelSetupFile.Text = Program.Fields["settingsForm_change_directory_install"];
            labelLang.Text = Program.Fields["settingsForm_change_lang"];
            labelTheme.Text = Program.Fields["settingsForm_change_theme"];
            buttonSaveChanged.Text = Program.Fields["settingsForm_save_change"];
        }
    }
}
