using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoriaJatek
{
    public partial class Game : Form
    {
        Random r = new Random();

        int parokSzama;
        int masodpercekSzama;
        int szamjegyekSzama;
        int zoldekSzama = 0;
        int kartyaSzam = 0;
        List<Point> poziciok = new List<Point>();
        int tmpX = 50;
        int tmpY = 50;
        List<int> marGeneraltSzamok = new List<int>();
        List<Label> Kartyak = new List<Label>();
        List<Label> forditottKartyak = new List<Label>();
        Stopwatch sw = new Stopwatch();

        public Game()
        {
            InitializeComponent();
        }

        public Game(int parokSzama, int masodpercekSzama, int szamjegyekSzama)
        {
            InitializeComponent();
            this.parokSzama = parokSzama;
            this.masodpercekSzama = masodpercekSzama;
            this.szamjegyekSzama = szamjegyekSzama;

            kartyaSzam = parokSzama * 2;

            ablakMeretBeallit(kartyaSzam);

            for(int i = 1; i <= kartyaSzam; i++)
            {
                poziciok.Add(new Point(tmpX, tmpY));

                if (i % (kartyaSzam / 3) == 0)
                {
                    tmpX = 50;
                    tmpY += 100;
                }                
                else
                {
                    tmpX += 100;
                }
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j <= parokSzama * 2 / 3 ; j++)
                {
                    if(poziciok.Count > 0)
                    {
                        if (szamjegyekSzama == 1)
                        {
                            labelElhelyezes(0, 9);
                        }
                        else
                        {
                            labelElhelyezes(10, 99);
                        }
                    }              
                }
            }
            felforditOsszes();
        }

        public void labelElhelyezes(int min, int max)
        {
            int randomSzam;

            do
            {
                randomSzam = r.Next(min, max + 1);
            } while (marGeneraltSzamok.Contains(randomSzam));

            int randomPozicioIndex = r.Next(0, kartyaSzam);
            labelKeszit(randomPozicioIndex, randomSzam);

            randomPozicioIndex = r.Next(0, kartyaSzam);
            labelKeszit(randomPozicioIndex, randomSzam);

            marGeneraltSzamok.Add(randomSzam);

        }

        public void labelKeszit(int randomPozicioIndex, int randomSzam)
        {
            Label label = new Label();
            label.Click += new EventHandler(Fordit);
            label.BackColor = Color.Purple;
            label.Size = new Size(80, 80);
            label.Font = new Font("Arial", 20);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.Purple;
            label.Text = randomSzam.ToString();
            label.Location = poziciok[randomPozicioIndex];

            Kartyak.Add(label);

            poziciok.RemoveAt(randomPozicioIndex);
            Controls.Add(label);
            kartyaSzam--;
        }

        public void Fordit(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (fordithatoE() < 1)
            {
                forditottKartyak.Add(label);
                label.ForeColor = Color.Black;
                label.BackColor = Color.Lavender;
            }
            else if (fordithatoE() == 1)
            {
                forditottKartyak.Add(label);
                label.ForeColor = Color.Black;
                label.BackColor = Color.Lavender;
                sw.Start();
            }

            if (forditottKartyak.Count == 2)
            {
                if (forditottKartyak[0].Text == forditottKartyak[1].Text)
                {
                    forditottKartyak[0].BackColor = Color.Green;
                    forditottKartyak[1].BackColor = Color.Green;
                    forditottKartyak[0].Enabled = false;
                    forditottKartyak[1].Enabled = false;
                    zoldekSzama++;
                    sw.Restart();
                    if (zoldekSzama == parokSzama)
                    {
                        MessageBox.Show("Gratulálunk!\nSikeresen végig játszottad a játékot!");
                    }
                }
                forditottKartyak.Clear();
            }
            
        }

        public void felforditOsszes()
        {
            timer2.Interval = 1000 * masodpercekSzama;
            timer2.Start();            
            for (int i = 0; i < parokSzama * 2; i++)
            {
                Kartyak[i].ForeColor = Color.Black;
                Kartyak[i].BackColor = Color.Lavender;
            }
                
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < parokSzama * 2; i++)
            {
                Kartyak[i].ForeColor = Color.Purple;
                Kartyak[i].BackColor = Color.Purple;
            }
            timer2.Stop();
        }


        public void ablakMeretBeallit(int kartyaSzam)
        {
            this.Size = new Size(kartyaSzam / 3 * 100 + 100, 500);
        }

        private int fordithatoE()
        {
            int forditottKartyaSzama = 0;

            for(int i = 0; i < Kartyak.Count; i++)
            {
                if (Kartyak[i].BackColor == Color.Lavender)
                {
                    forditottKartyaSzama++;
                }
            }

            return forditottKartyaSzama;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sw.Elapsed.Seconds == 1)
            {
                sw.Reset();

                for (int i = 0; i < Kartyak.Count; i++)
                {
                        if (Kartyak[i].BackColor == Color.Lavender)
                        {
                            Kartyak[i].BackColor = Color.Purple;
                            Kartyak[i].ForeColor = Color.Purple;
                        }


                }
            }
        }
    }
}
