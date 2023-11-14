using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoriaJatek
{
    public partial class Form1 : Form
    {
        public string almafa = "Piros";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Settings st = new Settings();

            st.ShowDialog();

            if(st.DialogResult == DialogResult.OK)
            {
                Game game = new Game(st.parokSzama, st.masodpercekSzama, st.szamjegyekSzama);

                game.ShowDialog();
            }
            
        }
    }
}
