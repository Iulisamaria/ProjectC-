using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD
{
    class Furnizor
    {
        public Furnizor(DataRow  insert)
        {
            ID = Convert.ToInt32(insert["ID"].ToString());
            Denumire=insert["Denumire"].ToString();
        }
        public int ID { get; set; }
        public string Denumire { get; set; }
    }
}
