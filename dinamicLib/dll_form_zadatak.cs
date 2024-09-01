using System;
using System.IO;
using System.Windows.Forms;

namespace dinamicLib
{
    public partial class dll_form_zadatak : Form
    {
        public dll_form_zadatak()
        {
            InitializeComponent();
        }

        private void buttonZadatakDa_Click(object sender, EventArgs e)
        {
            // postavi rezultat trenutne instance(this) na Yes i zatvori dijalog
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonZadatakNe_Click(object sender, EventArgs e)
        {
            // postavi rezultat trenutne instance(this) na No i zatvori dijalog
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void dll_form_zadatak_Load(object sender, EventArgs e)
        {

        }

    }
}
