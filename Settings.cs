using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoriaJatek
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void par6_CheckedChanged(object sender, EventArgs e)
        {
            masodperc10.Checked = true;
            masodperc5.Enabled = true;
            masodperc20.Enabled = false;
        }

        private void par9_CheckedChanged(object sender, EventArgs e)
        {
            masodperc10.Checked = true;
            masodperc5.Enabled = false;
            masodperc20.Enabled = true;
        }

        public int parokSzama {
            get
            {
                if(par6.Checked == true)
                {
                    return 6;
                }
                else
                {
                    return 9;
                }
            }     
        }

        public int masodpercekSzama
        {
            get
            {
                if (masodperc5.Checked == true)
                {
                    return 5;
                }
                else if (masodperc10.Checked == true)
                {
                    return 10;
                }
                else
                {
                    return 20;
                }
            }
        }

        public int szamjegyekSzama
        {
            get
            {
                if (egyjegyu.Checked == true)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
