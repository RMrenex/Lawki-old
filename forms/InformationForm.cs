using System.Windows.Forms;

namespace Lawki.forms
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
            labelContent.Text = Program.Fields["informationForm_author"] + 
                "\n" + Program.Fields["informationForm_version"] + 
                "\n" + Program.Fields["informationForm_language"] + 
                "\n" + Program.Fields["informationForm_os"] + 
                "\n" + Program.Fields["informationForm_copiryght"];
        }
    }
}
