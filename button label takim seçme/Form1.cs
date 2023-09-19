using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_label_takim_seçme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBesiktas_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "BEŞİKTAŞ";
            lblTakim.BackColor = Color.White;
            lblTakim.ForeColor = Color.Black;
        }

        private void btnRealmadrid_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "REAL MADRİD";


            lblTakim.BackColor = Color.Black;

            lblTakim.ForeColor = Color.White;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "BAYERN MUNİH";

            lblTakim.BackColor = Color.Blue;

            lblTakim.ForeColor = Color.Purple;


        }

        private void btnSamsunspor_Click(object sender, EventArgs e)
        {
            lblTakim.Text = "SAMSUNSPOR";

            lblTakim.ForeColor = Color.Red;

            lblTakim.BackColor = Color.White;

        }
    }
}
