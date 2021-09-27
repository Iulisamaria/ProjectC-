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
    public partial class Creeaza_Reteta : Form
    {
        Conection conn = new Conection();
        public Creeaza_Reteta()
        {
            InitializeComponent();
            GetLegatura();
        }

        private void comboboxproduse_Click(object sender, EventArgs e)
        {
            comboboxproduse.Items.Clear();
            comboboxid_produse.Items.Clear();
            var id = Administrare.GetMaterie();
            foreach (var name in id)
            {
                comboboxproduse.Items.Add(name.Denumire);
                comboboxid_produse.Items.Add(name.ID);

            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            comboboxid_produse.SelectedIndex = comboboxproduse.SelectedIndex;
            comboBoxReteta_id.SelectedIndex = comboBoxReteta.SelectedIndex;
            var ad=Administrare.AddProduseReteta(
                comboBoxReteta_id.Text,
                comboboxid_produse.Text,
                Convert.ToInt32(numericUpDowncantitate.Text),comboBoxUm.Text);
            
            GetLegatura();
        }
        public void GetLegatura()
        {
            conn.Open();
            string sql = "select m.denumire as ingredient, r.denumire as reteta,l.cantitate, l.um, l.id_reteta ,l.ID_PRODUSMATERIEPRIMA from legatura l, materieprima m,reteta r where l.id_reteta=r.id and m.ID=l.ID_PRODUSMATERIEPRIMA";
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id_reteta"].Visible = false;
                dataGridView1.Columns["ID_PRODUSMATERIEPRIMA"].Visible = false;


            }
            conn.Close();
        }

        private void comboBoxReteta_Click(object sender, EventArgs e)
        {
            comboBoxReteta.Items.Clear();
            comboBoxReteta_id.Items.Clear();
            var id = Administrare.GetReteta();
            foreach (var name in id)
            {
                comboBoxReteta.Items.Add(name.Nume_reteta);
                comboBoxReteta_id.Items.Add(name.ID);

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
                
                var num = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_reteta"].Value.ToString());
                var num2 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_PRODUSMATERIEPRIMA"].Value.ToString());


                Administrare.DeleteProdusReteta(num,num2);
                GetLegatura();
            }
        }

        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {

            TextBox txb = (TextBox)sender;

            conn.Open();
            string sql = "select m.denumire as ingredient, r.denumire as reteta,l.cantitate, l.um from legatura l, materieprima m,reteta r where l.id_reteta=r.id and m.ID=l.ID_PRODUSMATERIEPRIMA and  r.denumire like '" + txb.Text.ToUpper() + "%'";

            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                
            }


            conn.Close();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select m.denumire, SUM(l.Cantitate) from legatura l, materieprima m where l.id_produsmaterieprima=m.id group by m.denumire";

            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                
            }


            conn.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

