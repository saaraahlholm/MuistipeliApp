using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuistipeliApp1
{
    public partial class FrmTiedot : Form
    {
        //Esitellään nämä jo tässä, jotta koodi toimii
        TextBox tb = new TextBox();
        TextBox tb2 = new TextBox();
        Label lbl = new Label();
        Label lbl2 = new Label();
        public bool sopivanimi;
        public static string Pelaaja1 = "";
        public static string Pelaaja2 = "";
        public static List<Pelaaja> pelaajat = new List<Pelaaja>();

        public string pelaajatfilu = "pelaajatfilu.json"; //Json-tiedoston nimi

        public void SerializeJSON(List<Pelaaja> input) //Viedään listan tietoa jsoniin
        {
            string json = JsonConvert.SerializeObject(input);
            File.WriteAllText(pelaajatfilu, json);
        }
        public List<Pelaaja> DeserializeJSON() //Tuodaan tietoa json-tiedostosta
        {
            if (File.Exists(pelaajatfilu))
            {
                using (StreamReader r = new StreamReader(pelaajatfilu))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<Pelaaja>>(json);
                }
            }
            else
            {
                return null;
            }
        }
        public bool ValidNimi(string nimi, out string msg)
        {
            msg = "";
            if (nimi.Length <= 0)
            {
                msg = "Nimi pakollinen";
                return false;
            }
            else
            {
                return true;
            }

        }
        public void Yksinpeli() //Luodaan label ja textbox ohjelmallisesti
        {
            lbl.Location = new Point(btnYksinpeli.Location.X, btnYksinpeli.Location.Y + 75);
            lbl.Text = "Pelaaja 1. nimi:";
            lbl.Size = new Size(100, 25);
            this.Controls.Add(lbl);
            lbl.Visible = true;

            tb.Location = new Point(btnYksinpeli.Location.X, btnYksinpeli.Location.Y + 100);
            tb.Name = "tbPelaaja1";
            tb.Size = new Size(100, 30);
            tb.TextChanged += new EventHandler(this.tb_TextChanged);
            tb.Leave += new EventHandler(this.tb_Leave);
            tb.KeyPress += new KeyPressEventHandler(this.tb_KeyPress);
            tb.Validated += new EventHandler(this.tb_Validated);  //YRITIN NÄITÄ TEHDÄ, MUTTA EI TOIMI NIIN EI TOIMI
            tb.Validating += new CancelEventHandler(this.tb_Validating);
            this.Controls.Add(tb);
            tb.Visible = true;
        }

        public void Kaksinpeli() //Luodaan labelit ja textboxit ohjelmallisesti
        {
            Yksinpeli();

            lbl2.Visible = true;
            lbl2.Location = new Point(btnKaksinpeli.Location.X, btnKaksinpeli.Location.Y + 75);
            lbl2.Text = "Pelaaja 2. nimi:";
            lbl2.Size = new Size(100, 25);
            this.Controls.Add(lbl2);

            tb2.Visible = true;
            tb2.Location = new Point(btnKaksinpeli.Location.X, btnKaksinpeli.Location.Y + 100);
            tb2.Name = "tbPelaaja2";
            tb2.Size = new Size(100, 30);
            tb2.TextChanged += new EventHandler(this.tb_TextChanged);
            tb2.KeyPress += new KeyPressEventHandler(this.tb_KeyPress);
            tb2.Leave += new EventHandler(this.tb_Leave);
            tb2.Validated += new EventHandler(this.tb_Validated); 
            tb2.Validating += new CancelEventHandler(this.tb_Validating);
            this.Controls.Add(tb2);
        }
        public void TyhjennaLomake()
        {
            btnYksinpeli.Enabled = true;
            btnKaksinpeli.Enabled = true;

            tb.Clear();
            tb2.Clear();
            tb.Visible = false;
            tb2.Visible = false;
            lbl.Visible = false;
            lbl2.Visible = false;
            btn6.Enabled = false;
            btn10.Enabled = false;
            btn14.Enabled = false;
        }

        public FrmTiedot()
        {
            InitializeComponent();
            FrmTiedot.pelaajat = DeserializeJSON(); //Tuodaan pelaajien tiedot json-tiedostota pelaajat listaan
        }

        private void tb_Validated(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            errorProvider2.SetError(tb, "");
        }
        private void tb_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string errorMsg;
            if (!ValidNimi(tb.Text, out errorMsg))
            {
                e.Cancel = true;
                tb.Select();
                this.errorProvider2.SetError(tb, errorMsg);
            }
        }
        private void FrmTiedot_Load(object sender, EventArgs e) //Kun lomake ladataan pelin valinta napit on "pois käytöstä"
        {
            btn6.Enabled = false;
            btn10.Enabled = false;
            btn14.Enabled = false;
        }
        private void btnYksinpeli_Click(object sender, EventArgs e) //valitaan yksinpeli
        {
            btnKaksinpeli.Enabled = false; //käyttäjä ei voi valita enää kaksinpeliä
            Yksinpeli(); //täällä luodaan ohjelmallisesti labelit ja textboxit
        }
        private void btnKaksinpeli_Click(object sender, EventArgs e) //kun valittu kaksinpeli
        {
            btnYksinpeli.Enabled = false; //Yksinpeliä ei voi enää valita
            Kaksinpeli();//täällä luodaan ohjelmallisesti labelit ja textboxit
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e) //Texboxiin voi kirjoittaa vaan kirjaimia ja käyttää backspacea
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tb_Leave(object sender, EventArgs e) //Kun textboxita poistutaan, niin muuttaa alkukirjaimen isoksi
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text != String.Empty)
            {
                string nimi = tb.Text;

                nimi = nimi.Substring(0, 1).ToUpper() + nimi.Substring(1, nimi.Length - 1).ToLower(); //Pakotetaan eka kirjain isoksi

                tb.Text = nimi;
            }
        }

        private void tb_TextChanged(object sender, EventArgs e) //Kun textboxiin on kirjoitettu jotain, niin buttonit pelin valintaan aktivoituu
        {
            TextBox tb = (TextBox)sender;
            if (btnYksinpeli.Enabled == true)
            {
                if (ValidNimi(tb.Text, out string msg) == false) //pelaamaan ei pääse ellei ole syöttänyt nimeä
                {
                    btn6.Enabled = false;
                    btn10.Enabled = false;
                    btn14.Enabled = false;
                }
                else
                {
                    btn6.Enabled = true;
                    btn10.Enabled = true;
                    btn14.Enabled = true;
                }
            }
            else if (btnKaksinpeli.Enabled == true) //sama kaksinpelissä, molemmilla pelaajilla pitää olla nimet
            {
                if (tb.Text == string.Empty || tb2.Text == string.Empty)
                {
                    btn6.Enabled = false;
                    btn10.Enabled = false;
                    btn14.Enabled = false;
                }
                else
                {
                    btn6.Enabled = true;
                    btn10.Enabled = true;
                    btn14.Enabled = true;
                }
            }

        }
        private void btn6_Click(object sender, EventArgs e) //aloittaa 6 parin muistipelin
        {
            if (btnYksinpeli.Enabled == true && btnKaksinpeli.Enabled == false)
            {
                Pelaaja1 = tb.Text;
                Pelaaja2 = String.Empty;
            }
            else
            {
                Pelaaja1 = tb.Text;
                Pelaaja2 = tb2.Text;
            }


            FrmMuistipeli muistipeli6 = new FrmMuistipeli();
            muistipeli6.ShowDialog();  //avataan formi, jossa muistipeli 6 parilla
            TyhjennaLomake(); //palautetaan lomakkeen tiedot alkuperäisille asetuksille
        }

        private void btn10_Click(object sender, EventArgs e) //aloittaa uuden pelin 10 parilla
        {
            if (btnYksinpeli.Enabled == true && btnKaksinpeli.Enabled == false)
            {
                Pelaaja1 = tb.Text;
                Pelaaja2 = String.Empty;
            }
            else
            {
                Pelaaja1 = tb.Text;
                Pelaaja2 = tb2.Text;
            }

            FrmMuistipeli2 muistipeli10 = new FrmMuistipeli2();
            TyhjennaLomake();
            muistipeli10.ShowDialog();
        }
        private void btn14_Click(object sender, EventArgs e) //Aloittaa uuden pelin 14 parilla
        {
            if (btnYksinpeli.Enabled == true && btnKaksinpeli.Enabled == false)
            {
                Pelaaja1 = tb.Text;
                Pelaaja2 = String.Empty;
            }
            else
            {
                Pelaaja1 = tb.Text;
                Pelaaja2 = tb2.Text;
            }

            FrmMuistipeli3 muistipeli14 = new FrmMuistipeli3();
            TyhjennaLomake();
            muistipeli14.ShowDialog();
        }
        private void btnPelitilastoon_Click(object sender, EventArgs e) //siirtymä pelitilasto-lomakkeelle
        {
            FrmPelitilasto formipt = new FrmPelitilasto(FrmTiedot.pelaajat); //Luodaan pelitilasto-lomakkeesta muuttuja ja välitettä  pelaajat frmPelitilastolle
            formipt.ShowDialog();
        }
        private void btnLopeta_Click(object sender, EventArgs e) //Pelin lopetus
        {
            DialogResult dr;
            dr = MessageBox.Show("Oletko varma, että haluat lopettaa pelaamisen?", "Info", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes) //Jos vastaus kyllä, niin sulkee ohjelman
            {
                Application.Exit();
            }
        }
    }
}
