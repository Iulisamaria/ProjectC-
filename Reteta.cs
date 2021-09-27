using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD
{
    class Reteta
    {
        private DataRowCollection rows;

        public Reteta()
        {
        }

        public Reteta(DataRow insert)
        {
            ID = Convert.ToInt32(insert["ID"].ToString());
            Nume_reteta = Convert.ToString(insert["Denumire"]);
        }

        public Reteta(DataRowCollection rows)
        {
            this.rows = rows;
        }

        public int ID { get; set; }
        public string Nume_reteta { get; set; }
    }
}
