using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuistipeliApp1
{
    public partial class FrmPelitilasto : Form
    {
        public FrmPelitilasto(List<Pelaaja> pelaajat)
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pelaajat;
        }

        private void btnAloitaPeli_Click(object sender, EventArgs e) //Aloitetaan uusi peli
        {
            //FrmTiedot formitiedot = new FrmTiedot();
            this.Hide(); //Piilotetaan tämä formi
            //formitiedot.ShowDialog(); //avataan FrmTiedot
            this.Close(); //Sulje tämä formi
        }
        private void btnSulje_Click(object sender, EventArgs e) //Suljetaan appi, jos niin halutaan
        {
            DialogResult dr;
            dr = MessageBox.Show("Haluatko lopettaa pelaamisen?", "Info", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes) //Jos vastaus kyllä, niin sulkee ohjelman
            {
                Application.Exit();
            }

        }


    }
}
