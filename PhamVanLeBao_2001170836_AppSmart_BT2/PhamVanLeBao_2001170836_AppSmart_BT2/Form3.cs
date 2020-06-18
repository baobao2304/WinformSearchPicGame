using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhamVanLeBao_2001170836_AppSmart_BT2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllTxt(this);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            rdInTxt(this);
        }
        private void rdInTxt(Control ctr)
        {
            foreach (Control tr in ctr.Controls)
            {
                if (tr is TextBox)
                {
                    tr.Text = "aaasdfsdfsdsdasd";
                }
                else
                {
                    rdInTxt(tr);
                }
            }
        }
        private void clearAllTxt(Control ctr)
        {
            foreach (Control ct in ctr.Controls)
            {
                if (ct is TextBox)
                {
                    ct.Text = "";
                }
                else
                {
                    clearAllTxt(ct);
                }
            }
        }
    }
}
