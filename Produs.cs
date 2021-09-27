using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectBD
{
    class Produs
    {
        public Produs(DataRow insert)
        {
            ID = Convert.ToInt32(insert["ID"].ToString());
            Denumire = insert["denumire"].ToString();
            Cantitate = Convert.ToInt32(insert["Cantitate"].ToString());
            Um = insert["Um"].ToString();
            Pret = Convert.ToInt32(insert["Pret"].ToString());
            //Tva = Convert.ToInt32(insert["Tva"].ToString());
            Id_reteta= Convert.ToInt32(insert["ID_reteta"].ToString());

        }
        public int ID { get; set; }
        public int Pret { get; set; }
        public int Tva { get; set; }
        public int Id_reteta { get; set; }
        public string Denumire { get; set; }
        public int Cantitate { get; set; }
        public string Um { get; set; }
        public string ID_Furnizor { get; set; }
    }
}
