using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD
{
    class MateriePrima
    {
        internal string denumire;

        public MateriePrima()
        {
        }

        public MateriePrima(DataRowCollection rows)
        {
        }

            public MateriePrima(DataRow insert)
        {
            ID = Convert.ToInt32(insert["ID"].ToString());
            Denumire = insert["denumire"].ToString();
            Cantitate = Convert.ToInt32(insert["Cantitate"].ToString());
            Um = insert["Um"].ToString();
            ID_Furnizor = insert["ID_Furnizor"].ToString();

        }
        public int ID { get; set; }
        public string Denumire { get; set; }
        public int Cantitate { get; set; }
        public string Um { get; set; }
        public string ID_Furnizor { get; set; }
    }
}
