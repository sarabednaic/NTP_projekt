using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamicLib
{
    public partial class dll_form_projekt : Form
    {
        public dll_form_projekt()
        {
            InitializeComponent();
        }

        private void dll_form_projekt_Load(object sender, EventArgs e)
        {

        }

        private void buttonDaProjekt_Click(object sender, EventArgs e)
        {
            // postavi rezultat trenutne instance(this) na Yes i zatvori dijalog
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonNeProjekt_Click(object sender, EventArgs e)
        {
            // postavi rezultat trenutne instance(this) na No i zatvori dijalog
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
