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
    public partial class Retete : Form
    {
        Conection conn = new Conection();
        Reteta reteta = new Reteta();
        private static Validare v = new Validare();

        public Retete()
        {
            InitializeComponent();
            GetReteta();
            List<MateriePrima> list = new List<MateriePrima>();
            list = Administrare.GetMaterie();
            
        }
        public void GetReteta()
        {
            checkBoxdesc.Checked = false;
            checkBoxasc.Checked = false;

            conn.Open();
            string sql = "select denumire as NUME_RETETA from reteta ";
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
            }
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                if (!v.ValidareNume(numeretetatxt.Text))

                         Administrare.AddReteta(numeretetatxt.Text.ToUpper());
                GetReteta();
                numeretetatxt.Clear();
                  
            
                
            
            
          

        }

        private void t_Click(object sender, EventArgs e)
        {
            checkBoxdesc.Checked = false;
            checkBoxasc.Checked = false;
            GetReteta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Rand neselectat!");
            }
            else  if (!v.ValidareNume(numeretetatxt.Text) )
            {
                reteta.Nume_reteta = numeretetatxt.Text;
                var num= dataGridView1.SelectedRows[0].Cells["nume_reteta"].Value.ToString();
                var id = Administrare.GetIDReteta(num);
                reteta.ID =id.ID;
                Administrare.Editreteta(reteta);
                numeretetatxt.Clear();
                GetReteta();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Rand neselectat!");
            }
            else
            {
                var num = dataGridView1.SelectedRows[0].Cells["nume_reteta"].Value.ToString();

                Reteta id = Administrare.GetIDReteta(num);
                Administrare.DeleteReteta(id.ID);
                GetReteta();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                numeretetatxt.Text = dataGridView1.SelectedRows[0].Cells["nume_reteta"].Value.ToString();
            }
        }


        

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void checkBoxasc_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxdesc.Checked = false;
            conn.Open();
            string sql = "select denumire as NUME_RETETA from reteta order by denumire asc ";
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
            }
            conn.Close();
        }

        private void checkBoxdesc_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxasc.Checked = false;
            conn.Open();
            string sql = "select denumire as NUME_RETETA from reteta order   by  denumire desc ";
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
            }
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
