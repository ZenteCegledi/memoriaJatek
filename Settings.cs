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
            allRequiredIsChecked();
        }

        private void par9_CheckedChanged(object sender, EventArgs e)
        {
            masodperc10.Checked = true;
            masodperc5.Enabled = false;
            masodperc20.Enabled = true;
            allRequiredIsChecked();
        }

        private bool allRequiredIsChecked()
        {
            if(par6.Checked == true || par9.Checked == true)
            {
                if(masodperc5.Checked == true || masodperc20.Checked == true || masodperc10.Checked == true)
                {
                    if(egyjegyu.Checked == true || ketjegyu.Checked == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void ChangedRequired(object sender, EventArgs e)
        {
            if (allRequiredIsChecked())
            {
                Kezdes.Enabled = true;
            }
            else
            {
                Kezdes.Enabled = false;
            }
        }
    }
}
