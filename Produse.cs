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
    public partial class Produse : Form
    {
        Conection conn = new Conection();
        public Produse()
        {
            InitializeComponent();
            GetProdus();
        }
        public void GetProdus()
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            produs.ResetText();

            conn.Open();
            string sql = "select s.id,s.denumire, s.um, s.cantitate, s.pret , s.tva, r.denumire as Reteta  from stocprodusfinit s,reteta r where r.id=s.id_reteta";
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;


            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            id_reteta.SelectedIndex =  reteta.SelectedIndex;
           var ad= Administrare.AddProdusFinit(denumireprodustxt.Text.ToUpper(), Convert.ToInt32(comboBoxcantitate.Text), Convert.ToInt32(prettxt.Text), tvatxt.Text,id_reteta.Text);
            
            List<Legatura> list = Administrare.GetCantitate(id_reteta.Text);
          int cant= Convert.ToInt32(comboBoxcantitate.Text)/10;

            foreach (Legatura el in list)
            {
                MateriePrima m = Administrare.GetStocMateriePrima(el.ID_produs);
                if (m.Cantitate-cant * Convert.ToInt32(el.Cantitate.ToString())> 0)
                    Administrare.EditStoc(cant, id_reteta.Text, Convert.ToInt32(el.Cantitate), el.ID_produs.ToString());
                else
                    MessageBox.Show("Stoc produs " + el.ID_produs + " este 0");
            }
            GetProdus();
            
        }

        private void reteta_Click(object sender, EventArgs e)
        {
            
                reteta.Items.Clear();
                id_reteta.Items.Clear();
                var id = Administrare.GetReteta();
                foreach (var name in id)
                {
                    reteta.Items.Add(name.Nume_reteta);
                    id_reteta.Items.Add(name.ID);

                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var produs = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(produs.Cells["id"].Value);
            Administrare.DeleteProdusFinit(id);
            GetProdus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            conn.Open();
            string sql = "select s.id, s.denumire, s.um, s.cantitate, s.pret , s.tva, r.denumire as Reteta  from stocprodusfinit s,reteta r where r.id=s.id_reteta order by s.denumire  asc";
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
            checkBox1.Checked= false;
            conn.Open();
            string sql = "select s.id, s.denumire, s.um, s.cantitate, s.pret , s.tva, r.denumire as Reteta  from stocprodusfinit s,reteta r where r.id=s.id_reteta order  by  s.denumire  desc ";
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;


            }
            conn.Close();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            produs.Items.Clear();
            var id = Administrare.GetProdus();
            foreach (var name in id)
            {
                produs.Items.Add(name.Pret);
              

            }

        }

        private void produs_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select .id, s.denumire, s.um, s.cantitate, s.pret , s.tva, r.denumire as Reteta  from stocprodusfinit s,reteta r where r.id=s.id_reteta and s.pret= " + produs.Text;
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;


            }
            conn.Close();

        }

        private void search_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txb = (TextBox)sender;

            conn.Open();
            string sql = "select s.id s.denumire, s.um, s.cantitate, s.pret , s.tva, r.denumire as Reteta  from stocprodusfinit s,reteta r where r.id=s.id_reteta and denumire like '" + txb.Text.ToUpper() + "%'";

            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

            }


            conn.Close();

        }

        private void t_Click(object sender, EventArgs e)
        {
            GetProdus();
        }
    }
}
