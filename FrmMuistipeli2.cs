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
{//SAMA KOODI KUIN 6 PARIN ALUSTALLA, MUTTA KUVIA VAIN LISÄTTY
    public partial class FrmMuistipeli2 : Form
    {
        FrmTiedot t = new FrmTiedot();
        bool salliklikki = false;
        PictureBox ekaarvaus;
        Random rnd = new Random();
        bool pelaaja1Vuoro, pelaaja2Vuoro;
        string voittaja; //tähän talteen kuka voitti
        int pelaaja1Pisteet, pelaaja2Pisteet;
        bool suljeRaksista = false;
        int sec = 45;
        Pelaaja Ekapelaaja = new Pelaaja();
        Pelaaja Tokapelaaja = new Pelaaja();

        public string pelaajatfilu = "pelaajatfilu.json";
        public void SerializeJSON(List<Pelaaja> input) //Viedään tietoa
        {
            string json = JsonConvert.SerializeObject(input);
            File.WriteAllText(pelaajatfilu, json);
        }
        public List<Pelaaja> DeserializeJSON() //Tehdään lista, json-tiedoston sisällöstä
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
        private PictureBox[] kuvaboksit
        {
            get { return Controls.OfType<PictureBox>().ToArray(); } //lisätään kaikki kuvaboksit listaan
        }
        private static IEnumerable<Image> kuvalogot
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.kalpa,
                    Properties.Resources.karpat,
                    Properties.Resources.tps,
                    Properties.Resources.assat,
                    Properties.Resources.hifk,
                    Properties.Resources.sport,
                    Properties.Resources.hpk,
                    Properties.Resources.ilves,
                    Properties.Resources.jyp,
                    Properties.Resources.jukurit
                };
            }
        }

        private void PiilotaKuvat() //Piilotetaan jäkislogot
        {
            foreach (var kuvat in kuvaboksit)
            {
                kuvat.Image = Properties.Resources.back; //laittaa kaikille kuville "takapuolen" näkyviin
            }
        }
        private PictureBox EtsiTyhjaKuvaboksi()
        {
            int i;

            do
            {
                i = rnd.Next(0, kuvaboksit.Count());
            } while (kuvaboksit[i].Tag != null);

            return kuvaboksit[i];
        }
        private void ArvoKuvat()
        {
            foreach (var kuva in kuvalogot)
            {
                EtsiTyhjaKuvaboksi().Tag = kuva;
                EtsiTyhjaKuvaboksi().Tag = kuva;
            }
        }
        private void PeliPaattyy()
        {
            tmrPeli2.Stop();
            suljeRaksista = true;
            DialogResult dr;
            dr = MessageBox.Show(voittaja + "\nHaluatko pelata uudelleen?", "Info", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes) //Jos vastaus kyllä, niin aloitetaan peli alusta
            {
                sec = 45;
                PelaaUudelleen();
            }
            else //muutoin suljetaan formi ja palataan pelin alkuun
            {
                //FrmTiedot frmTiedot = new FrmTiedot();
                this.Hide();
                //frmTiedot.ShowDialog();
                this.Close();
            }
        }
        public void TalletaTiedot()
        {
            if (FrmTiedot.pelaajat.Any<Pelaaja>(x => x.Etunimi == Ekapelaaja.Etunimi))
            {
                int p1 = FrmTiedot.pelaajat.FindIndex(e => e.Etunimi.Equals(Ekapelaaja.Etunimi));
                if (pelaaja1Pisteet > pelaaja2Pisteet)
                {
                    FrmTiedot.pelaajat[p1].Voitot++;
                }
                else if (pelaaja1Pisteet < pelaaja2Pisteet)
                {
                    FrmTiedot.pelaajat[p1].Tappiot++;
                }
                else
                {
                    FrmTiedot.pelaajat[p1].Tasapelit++;
                }
            }
            else
            {
                Pelaaja uusiPelaaja = new Pelaaja();
                uusiPelaaja.Etunimi = Ekapelaaja.Etunimi;
                if (pelaaja1Pisteet > pelaaja2Pisteet)
                {
                    uusiPelaaja.Voitot++;
                }
                else if (pelaaja1Pisteet < pelaaja2Pisteet)
                {
                    uusiPelaaja.Tappiot++;
                }
                else
                {
                    uusiPelaaja.Tasapelit++;
                }
                FrmTiedot.pelaajat.Add(uusiPelaaja);
            }
            if (lblPelaaja2Nimi.Text != String.Empty)
            {
                if (FrmTiedot.pelaajat.Any<Pelaaja>(x => x.Etunimi == Tokapelaaja.Etunimi))
                {
                    int p2 = FrmTiedot.pelaajat.FindIndex(e => e.Etunimi.Equals(Tokapelaaja.Etunimi));
                    if (pelaaja1Pisteet < pelaaja2Pisteet)
                    {
                        FrmTiedot.pelaajat[p2].Voitot++;
                    }
                    else if (pelaaja1Pisteet > pelaaja2Pisteet)
                    {
                        FrmTiedot.pelaajat[p2].Tappiot++;
                    }
                    else
                    {
                        FrmTiedot.pelaajat[p2].Tasapelit++;
                    }
                }
                else
                {
                    Pelaaja uusiPelaaja2 = new Pelaaja();
                    uusiPelaaja2.Etunimi = Tokapelaaja.Etunimi;
                    if (pelaaja1Pisteet < pelaaja2Pisteet)
                    {
                        uusiPelaaja2.Voitot++;
                    }
                    else if (pelaaja1Pisteet > pelaaja2Pisteet)
                    {
                        uusiPelaaja2.Tappiot++;
                    }
                    else
                    {
                        uusiPelaaja2.Tasapelit++;
                    }
                    FrmTiedot.pelaajat.Add(uusiPelaaja2);
                }
            }
            SerializeJSON(FrmTiedot.pelaajat);
        }
        private void PelaaUudelleen()
        {
            foreach (var kuva in kuvaboksit)
            {
                kuva.Tag = null;
                kuva.Visible = true;
            }

            salliklikki = true;
            ArvoKuvat();
            PiilotaKuvat();
            btnAloitapeli.Enabled = false;
            pelaaja1Pisteet = 0;
            lblPelaaja1pisteet.Text = pelaaja1Pisteet.ToString();

            if (lblPelaaja2Nimi.Text != string.Empty)
            {
                pelaaja2Pisteet = 0;
                lblPelaaja2Pisteet.Text = pelaaja2Pisteet.ToString();
            }
            else
            {
                tmrPeli2.Start();
            }
        }
        private void LaskePisteet()
        {
            if (FrmTiedot.Pelaaja2 != String.Empty)
            {
                if (pelaaja1Vuoro == true)
                {
                    pelaaja1Pisteet++;
                    lblPelaaja1pisteet.Text = pelaaja1Pisteet.ToString();
                }
                else
                {
                    pelaaja2Pisteet++;
                    lblPelaaja2Pisteet.Text = pelaaja2Pisteet.ToString();
                }
            }
            else
            {
                pelaaja1Pisteet++;
                lblPelaaja1pisteet.Text = pelaaja1Pisteet.ToString();

            }
        }
        private void TarkasteleVoittaja()
        {
            if (pelaaja1Pisteet > pelaaja2Pisteet)
            {
                voittaja = "Voittaja on: " + lblPelaaja1Nimi.Text;
            }
            else if (pelaaja1Pisteet < pelaaja2Pisteet)
            {
                voittaja = "Voittaja on: " + lblPelaaja2Nimi.Text;
            }
            else
            {
                voittaja = "Tasapeli!";
            }
        }
        private void Vuoronvaihto()
        {
            if (FrmTiedot.Pelaaja2 != String.Empty) //Jos pelaajaa valitsi yksinpelin, niin vuoronvaihdot eivät toimi
            {
                if (pelaaja1Vuoro == true)
                {
                    pelaaja1Vuoro = false;
                    pelaaja2Vuoro = true;
                    lblKenenVuoro.Text = lblPelaaja2Nimi.Text + ", sinun vuorosi!";
                }
                else
                {
                    pelaaja1Vuoro = true;
                    pelaaja2Vuoro = false;
                    lblKenenVuoro.Text = lblPelaaja1Nimi.Text + ", sinun vuorosi!";
                }
            }
        }
        public FrmMuistipeli2()
        {
            InitializeComponent();

            FrmTiedot.pelaajat = DeserializeJSON(); //Tämä hakee karhuhavainnot tiedostosta

            if (FrmTiedot.pelaajat == null) //Jos tiedostossa ei ole mitään, niin luodaan lista.
            {
                FrmTiedot.pelaajat = new List<Pelaaja>();
            }
        }

        private void FrmMuistipeli2_Load(object sender, EventArgs e)
        {
            //niin nimet latautuu edellisetä sivulta
            Ekapelaaja.Etunimi = FrmTiedot.Pelaaja1;
            lblPelaaja1Nimi.Text = Ekapelaaja.Etunimi;
            lblPelaaja1pisteet.Text = pelaaja1Pisteet.ToString();

            //Montakopelaajaa oli, niin nimet esille sen mukaan
            if (FrmTiedot.Pelaaja2 != String.Empty)
            {
                Tokapelaaja.Etunimi = FrmTiedot.Pelaaja2;
                lblPelaaja2Nimi.Text = Tokapelaaja.Etunimi;
                lblPelaaja2Pisteet.Text = pelaaja2Pisteet.ToString();
            }
            else
            {
                lblPelaaja2Nimi.Text = "";
                lblPelaaja2Pisteet.Text = "";
            }

            //lisätään eventhandler formin sulkemiselle
            this.FormClosing += new FormClosingEventHandler(FrmMuistipeli2_Closing_1);
        }

        private void btnAloitapeli_Click(object sender, EventArgs e)
        {
            if (lblPelaaja2Nimi.Text == String.Empty)
            {
                lblPelikello2.Visible = true;
                tmrPeli2.Start(); //jos yksinpeli niin käynnistettään pelikello
            }
            salliklikki = true;
            ArvoKuvat();
            PiilotaKuvat();
            btnAloitapeli.Enabled = false;

            pelaaja1Vuoro = true; //pelaaja 1 aloittaa aina
            pelaaja2Vuoro = false;

            lblKenenVuoro.Visible = true;
            lblKenenVuoro.Text = lblPelaaja1Nimi.Text + ", sinun vuorosi!";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (!salliklikki) //jos salliklikki on false
            {
                return; //Hypätään funtiosta ulos
            }

            PictureBox kuva = (PictureBox)sender; //ottaa ylös, mitä kuvakorttia klikattiin

            if (ekaarvaus == null)
            {
                ekaarvaus = kuva;
                kuva.Image = (Image)kuva.Tag;
                return;
            }

            kuva.Image = (Image)kuva.Tag; //Tämä ottaa ylös toisen kuvan klikin

            if (kuva.Image == ekaarvaus.Image && kuva != ekaarvaus) //Jos arvaa oikein, et pysty klikkaamaan samaa kuvaa kahdesti
            {
                kuva.Visible = ekaarvaus.Visible = false;
                {
                    ekaarvaus = kuva;
                }
                PiilotaKuvat();
                LaskePisteet();
            }

            else //Kuvaparit eivät olleet samat
            {
                salliklikki = false;
                tmrArvausaika.Start();

                Vuoronvaihto();

            }
            ekaarvaus = null;

            if (kuvaboksit.Any(p => p.Visible)) //Onko esillä enää kuvia?
            {
                return;
            }

            TarkasteleVoittaja(); //Tässä katsotaan kuka voitti vai tuliko tasapeli
            TalletaTiedot();
            PeliPaattyy(); //Messagebox esille
        }

        private void tmrPeli2_Tick(object sender, EventArgs e)
        {
            sec--;
            lblPelikello2.Text = sec.ToString();
            if (sec == 0)
            {
                tmrPeli2.Stop();
                MessageBox.Show("Hävisit pelin", "Info");
                if (FrmTiedot.pelaajat.Any<Pelaaja>(x => x.Etunimi == Ekapelaaja.Etunimi))
                {
                    int p1 = FrmTiedot.pelaajat.FindIndex(y => y.Etunimi.Equals(Ekapelaaja.Etunimi));
                    FrmTiedot.pelaajat[p1].Tappiot++;
                }
                else
                {
                    Pelaaja uusiPelaaja = new Pelaaja();
                    uusiPelaaja.Etunimi = Ekapelaaja.Etunimi;
                    uusiPelaaja.Tappiot++;
                    FrmTiedot.pelaajat.Add(uusiPelaaja);
                }
                SerializeJSON(FrmTiedot.pelaajat);
                PeliPaattyy();
            }
        }

        private void tmrArvausaika_Tick(object sender, EventArgs e)
        {
            PiilotaKuvat();
            salliklikki = true;
            tmrArvausaika.Stop();
        }

        private void FrmMuistipeli2_Closing_1(object sender, System.ComponentModel.CancelEventArgs e) //Jos käyttäjä yrittää sulkea pelin formin 
        {
            tmrPeli2.Stop();
            if (suljeRaksista == false)
            {
                DialogResult vastaus;
                vastaus = MessageBox.Show("Peli kesken. Haluatko lopettaa pelaamisen?", "Info", MessageBoxButtons.YesNo);

                if (vastaus == DialogResult.Yes) //Jos vastaus kyllä, niin sulkee ohjelman
                {
                    e.Cancel = false;

                }
                else //jos vastaus ei,  niin jatkaa peliä
                {
                    e.Cancel = true;
                    tmrPeli2.Start();
                }
            }
        }
    }
}
