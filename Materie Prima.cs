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
    public partial class Materie_Prima : Form
    {
        Conection conn = new Conection();
        MateriePrima m = new MateriePrima();
        private static Validare v = new Validare();
        public Materie_Prima()
        {
            InitializeComponent();
            GetMATERIEPRIMA();
        }


        private void comboBox1_Click(object sender, EventArgs e)
        {
            furnizor.Items.Clear();
            id_furnizor.Items.Clear();
            var id = Administrare.GetFurnizori();
            foreach (var name in id)
            {
                furnizor.Items.Add(name.Denumire);
                id_furnizor.Items.Add(name.ID);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            id_furnizor.SelectedIndex = furnizor.SelectedIndex;
            if (!v.ValidareNume(denumiretxt.Text)|| cantitatetxt.Text==null || furnizor.SelectedItem== null|| umtxt.SelectedItem== null)
            {
                denumire.ForeColor = Color.Red;
                cantitate.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                um.ForeColor = Color.Red;
                MessageBox.Show("Date incorecte!");

            }
            else
            {

                denumire.ForeColor = Color.Black;
                cantitate.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                um.ForeColor = Color.Black;
                var ex = Administrare.EditCantitate(Convert.ToInt32(cantitatetxt.Text), denumiretxt.Text.ToUpper(), id_furnizor.Text);

                if (ex != "OK")
                {
                    Administrare.AddMateriePrima(denumiretxt.Text.ToUpper(), Int32.Parse(cantitatetxt.Text), umtxt.Text.ToUpper(), id_furnizor.Text);

                }
                else
                {
                    Administrare.EditCantitate(Convert.ToInt32(cantitatetxt.Text) - Convert.ToInt32(cantitatetxt.Text), denumiretxt.Text.ToUpper(), id_furnizor.Text);


                }

                denumiretxt.Clear();
                cantitatetxt.Clear();
                umtxt.ResetText();
                furnizor.ResetText();
                GetMATERIEPRIMA();

            }


        }

        public void GetMATERIEPRIMA()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            stoc.Checked = false;
            comboBox2.ResetText();

            conn.Open();
            string sql = "select m.id, m.denumire, m.cantitate, m.um, f.denumire AS Furnizor from MATERIEPRIMA m, Furnizor f where m.id_furnizor=f.id";
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
            

            GetMATERIEPRIMA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Rand neselectat!");
            }
            else
            {
                var produs = dataGridView1.SelectedRows[0];
                var id = produs.Cells["denumire"].Value.ToString();
                Administrare.DeleteProdus(id);
                GetMATERIEPRIMA();
            }
        }

        private void denumiretxt_Enter(object sender, EventArgs e)
        {
            id_furnizor.SelectedIndex = furnizor.SelectedIndex;
            List<MateriePrima> listMaterie = new List<MateriePrima>();
            listMaterie = Administrare.GetMaterie();
            foreach (var el in listMaterie)
            {
                if (denumiretxt.Text == el.denumire)
                {
                    furnizor.SelectedItem = el.ID_Furnizor;
                    umtxt.Text = el.Um;
                }
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            id_furnizor.SelectedIndex = furnizor.SelectedIndex;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                denumiretxt.Text = dataGridView1.SelectedRows[0].Cells["denumire"].Value.ToString();
                cantitatetxt.Text = dataGridView1.SelectedRows[0].Cells["cantitate"].Value.ToString();
                umtxt.Text = dataGridView1.SelectedRows[0].Cells["um"].Value.ToString();
                furnizor.Text= dataGridView1.SelectedRows[0].Cells["furnizor"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Rand neselectat!");
            }
            else {
                
                m.Cantitate = Convert.ToInt32(cantitatetxt.Text);
                m.Denumire = denumiretxt.Text;
                m.Um = umtxt.Text;
                var denum = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                var id = Administrare.GetIDMaterieprima(denum);
                m.ID = id.ID;
                Administrare.EditMaterie(m);

                denumiretxt.Clear();
                cantitatetxt.Clear();
                umtxt.ResetText();
                furnizor.ResetText();
               
                GetMATERIEPRIMA();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            conn.Open();
            string sql = "select m.id,m.denumire, m.cantitate, m.um, f.denumire AS Furnizor from MATERIEPRIMA m, Furnizor f where m.id_furnizor = f.id order by m.denumire asc";
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
            filterfurnizor.Items.Clear();
            comboBox2.Items.Clear();
            stoc.Checked = false;
            conn.Open();
            string sql = "select m.id,m.denumire, m.cantitate, m.um, f.denumire AS Furnizor from MATERIEPRIMA m, Furnizor f where m.id_furnizor = f.id order by m.denumire desc";
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

            filterfurnizor.Items.Clear();
            comboBox2.Items.Clear();
            var id = Administrare.GetFurnizori();
            foreach (var name in id)
            {
                filterfurnizor.Items.Add(name.ID);
                comboBox2.Items.Add(name.Denumire);

            }

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn.Open();
            filterfurnizor.SelectedIndex = comboBox2.SelectedIndex;



            string sql = "select m.id,m.denumire, m.cantitate, m.um, f.denumire AS Furnizor from MATERIEPRIMA m, Furnizor f where m.id_furnizor = f.id and m.id_furnizor='" + filterfurnizor.SelectedItem.ToString() + "'";
            using (var reader = conn.ExecuteReader(sql))
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

            }


            conn.Close();
        }

        private void stoc_CheckedChanged(object sender, EventArgs e)
        {

            conn.Open();
            string sql = "select m.id,m.denumire, m.cantitate, m.um, f.denumire AS Furnizor from MATERIEPRIMA m, Furnizor f where m.id_furnizor = f.id and cantitate=0";
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
                string sql = "select m.id,m.denumire, m.cantitate, m.um, f.denumire AS Furnizor from MATERIEPRIMA m, Furnizor f where m.id_furnizor = f.id and  m.denumire like '"+txb.Text.ToUpper()+"%'";

                using (var reader = conn.ExecuteReader(sql))
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;

            }


            conn.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
        

