using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowaPasswd.forms
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
