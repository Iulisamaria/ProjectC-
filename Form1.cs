using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Furnizori f1 = new Furnizori();
            f1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Materie_Prima f1 = new Materie_Prima();
            f1.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Retete r = new Retete();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produse p = new Produse();
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                Creeaza_Reteta c = new Creeaza_Reteta();
                c.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
