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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MuistipeliApp1
{
    public partial class FrmMuistipeli : Form
    {
        FrmTiedot t = new FrmTiedot();
        bool salliklikki = false;
        PictureBox ekaarvaus;
        Random rnd = new Random();
        bool pelaaja1Vuoro, pelaaja2Vuoro;
        string voittaja; //tähän talteen kuka voitti
        int pelaaja1Pisteet, pelaaja2Pisteet;
        bool suljeRaksista = false;
        int sec = 30;
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
                    return JsonConvert.DeserializeObject<List<Pelaaja>>(json); //palauttaa pelaaja-listan
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
            get //haetaan kuvat
            {
                return new Image[]
                {
                    Properties.Resources.kalpa,
                    Properties.Resources.karpat,
                    Properties.Resources.tps,
                    Properties.Resources.assat,
                    Properties.Resources.hifk,
                    Properties.Resources.sport
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
        private PictureBox EtsiTyhjaKuvaboksi() //etsii kuvabokseja, joiden arvo on null (hyödynnetään seuraavassa funktiossa)
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
            foreach (var kuva in kuvalogot) //käy läpi kuvat ja tarkistaa, millä on samat tägit eli ovat pari
            {
                EtsiTyhjaKuvaboksi().Tag = kuva; //kääntää kuvat "oikein päin"
                EtsiTyhjaKuvaboksi().Tag = kuva;
            }
        }
        private void PeliPaattyy()
        {
            tmrPeli.Stop(); //stopataan pelikello
            suljeRaksista = true;
            DialogResult dr;
            dr = MessageBox.Show(voittaja + "\nHaluatko pelata uudelleen?", "Info", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes) //Jos vastaus kyllä, niin aloitetaan peli alusta
            {
                sec = 30; //alustetaan pelikello uudelleen
                PelaaUudelleen();
            }
            else //muutoin suljetaan tämä formi ja palataan pelin alkuun
            {
               // FrmTiedot frmTiedot = new FrmTiedot();
                this.Hide();
                this.Close();
            }
        }
        public void TalletaTiedot()
        {
            if (FrmTiedot.pelaajat.Any<Pelaaja>(x => x.Etunimi == Ekapelaaja.Etunimi)) //tarkastellaan onko pelaaja jo olemassa listassa
            { //ja jos on niin
                int p1 = FrmTiedot.pelaajat.FindIndex(e => e.Etunimi.Equals(Ekapelaaja.Etunimi)); //etsitään listasta oikean niminen pelaaja
                if (pelaaja1Pisteet > pelaaja2Pisteet)
                {
                    FrmTiedot.pelaajat[p1].Voitot++; //kenelle pisteet tulee
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
            else //ja jos ks. pelaajaa ei listasta vielä löytynyt
            {
                Pelaaja uusiPelaaja = new Pelaaja(); //luodaan uusi pelaaja
                uusiPelaaja.Etunimi = Ekapelaaja.Etunimi;
                if (pelaaja1Pisteet > pelaaja2Pisteet)
                {
                    uusiPelaaja.Voitot++; //ja lisätään pisteet hälle
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
            if (lblPelaaja2Nimi.Text != String.Empty) //jos on kaksinpeli
            {
                if (FrmTiedot.pelaajat.Any<Pelaaja>(x => x.Etunimi == Tokapelaaja.Etunimi)) //tehdään sama homma pelaaja 2
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

            SerializeJSON(FrmTiedot.pelaajat); //tallennetaan tiedot
        }
        private void PelaaUudelleen()
        {
            foreach (var kuva in kuvaboksit)
            {
                kuva.Tag = null; //ja kuvien tägit nollataan
                kuva.Visible = true; //kaikki kuvat tulee taas näkyviin
            }

            salliklikki = true;
            ArvoKuvat();
            PiilotaKuvat();
            btnAloitapeli.Enabled = false;
            pelaaja1Pisteet = 0; //nollataan pisteet
            lblPelaaja1pisteet.Text = pelaaja1Pisteet.ToString();

            if (lblPelaaja2Nimi.Text != string.Empty) //jos kaksinpeli niin nollataan pelaaja2 pisteet 
            {
                pelaaja2Pisteet = 0;
                lblPelaaja2Pisteet.Text = pelaaja2Pisteet.ToString();
            }
            else
            {
                tmrPeli.Start(); //yksinpelissä käynnistettään pelikello
            }
        }
        private void LaskePisteet()
        {
            if (FrmTiedot.Pelaaja2 != String.Empty) //tarkastellaan oliko yksin- vai kaksinpeli
            {
                if (pelaaja1Vuoro == true) //jos oli kaksinpeli niin molempien pelaajien pisteet on näkyvillä
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
            else //muuten vain 1. pelaajan pisteet näkyy
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
        public FrmMuistipeli()
        {
            InitializeComponent();

            FrmTiedot.pelaajat = DeserializeJSON(); //Tämä hakee pelaajat ja tilastot tiedostosta

            if (FrmTiedot.pelaajat == null) //Jos tiedostossa ei ole mitään, niin luodaan lista.
            {
                FrmTiedot.pelaajat = new List<Pelaaja>();
            }
        }
        private void FrmMuistipeli_Load(object sender, EventArgs e) //kun lomake latautuu
        {

            //niin nimet latautuu edellisetä sivulta
            Ekapelaaja.Etunimi = FrmTiedot.Pelaaja1;
            lblPelaaja1Nimi.Text = Ekapelaaja.Etunimi;
            lblPelaaja1pisteet.Text = pelaaja1Pisteet.ToString();

            //Montako pelaajaa oli, niin nimet esille sen mukaan
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
            this.FormClosing += new FormClosingEventHandler(FrmMuistipeli_Closing_1);
        }
        private void btnAloitapeli_Click(object sender, EventArgs e)
        {
            if(lblPelaaja2Nimi.Text == String.Empty)
            {
                lblPelikello.Visible = true;
                tmrPeli.Start(); //jos yksinpeli niin käynnistettään pelikello
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
        private void pictureBox1_Click(object sender, EventArgs e) //kun klikataan muistikorttia
        {
            if (!salliklikki) //jos salliklikki on false
            {
                return; //Hypätään funktiosta ulos
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
                kuva.Visible = ekaarvaus.Visible = false; //oikein arvattu pari "häviää" pelialustalta
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

        private void tmrPeli_Tick(object sender, EventArgs e)
        {
            sec--;
            lblPelikello.Text = sec.ToString();
            if (sec == 0)
            {
                tmrPeli.Stop();
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

        private void tmrArvausaika_Tick(object sender, EventArgs e) //Kun ajastin "tikkaa"
        {
            PiilotaKuvat();
            salliklikki = true;
            tmrArvausaika.Stop();
        }
        private void FrmMuistipeli_Closing_1(object sender, System.ComponentModel.CancelEventArgs e) //Jos käyttäjä yrittää sulkea pelin formin 
        {
            tmrPeli.Stop(); //pysäytetään pelikello
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
                    tmrPeli.Start(); //käynnistetään pelikello uudelleen
                }
            }
        }
    }
}
