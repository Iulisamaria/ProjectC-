using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD
{
    class Legatura
    {
        public Legatura(DataRow insert)
        {
            ID_reteta = Convert.ToInt32(insert["ID_RETETA"].ToString());
            ID_produs = Convert.ToInt32(insert["ID_PRODUSMATERIEPRIMA"].ToString());
            Cantitate = Convert.ToInt32(insert["Cantitate"].ToString());

            //UM = insert["UM"].ToString();
        }
        public int ID_reteta { get; set; }
        public int ID_produs { get; set; }
         public int Cantitate { get; set; }
       

        public string UM { get; set; }
        
    }
}
