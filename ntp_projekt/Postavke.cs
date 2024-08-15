using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_projekt
{
    public partial class Postavke : Form
    {
        public Postavke()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PostavkeOdjavaButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Prijava();
        }

        private void PostavkeDeaktivacijaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new Deaktivacija_racuna();
        }

        private void PostavkePromjenaButton_Click(object sender, EventArgs e)
        {
            if(PostavkeImeTextBox.Text != Session.Ime)
            {

            }

            if(PostavkePrezimeTextBox.Text != Session.Prezime)
            {

            }

            if(PostavkeKorisnickoImeTextBox.Text != Session.KorisnickoIme)
            {

            }

            if(PostavkeLozinkaTextBox.Text !="" && PostavkePonovnoLozinkaTextBox.Text != "")
            {
                if(PostavkeLozinkaTextBox.Text == PostavkePonovnoLozinkaTextBox.Text)
                {

                }
            }


            StartApk.MainFormManager.TrenutnaForma = new Postavke();
        }

        private void PostavkeNatragButton_Click(object sender, EventArgs e)
        {
            StartApk.MainFormManager.TrenutnaForma = new PopisProjekta();
        }

        private void Postavke_Load(object sender, EventArgs e)
        {
            PostavkeImeTextBox.Text = Session.Ime;
            PostavkePrezimeTextBox.Text = Session.Prezime;
            PostavkeKorisnickoImeTextBox.Text = Session.KorisnickoIme;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
