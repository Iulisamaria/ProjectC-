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
    public partial class Furnizori : Form
    {
        private const bool SUCCES = true;
        Validare v = new Validare();

        public Furnizori()
        {
            InitializeComponent();
            GetFurnizor();
        }

        private void Adaugare_Click(object sender, EventArgs e)
        {
            
            if(!v.ValidareNume(txtfurnizor.Text))
           {
                var ad = Administrare.AddFurnizor(txtfurnizor.Text.ToUpper());
                
            }
            txtfurnizor.Clear();
            GetFurnizor();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetFurnizor();
                
       }
        Conection conn = new Conection();
        public void GetFurnizor()
        {
            txtfurnizor.Clear();
            conn.Open();
            string sql = "select id,denumire as Furnizor from furnizor";
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Rand neselectat!");
            }
            else
            {
                var id1 = dataGridView1.SelectedRows[0];
                var id = Convert.ToInt32(id1.Cells["id"].Value.ToString());
                Administrare.DeleteFurnizor(id);
                GetFurnizor();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            conn.Open();

            string sql = "select id denumire as Furnizor from furnizor order by denumire asc";
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

            }
            conn.Close();


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            conn.Open();
            string sql = "select id, s,denumire as Furnizor from furnizor order by denumire desc";
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

            }
            conn.Close();
        }

        public void  GetDenumire(string denumire)
        {
            conn.Open();
            string sql = "select * from furnizor where denumire like ' %" + denumire + "'";

            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;


            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetDenumire(textBox1.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
