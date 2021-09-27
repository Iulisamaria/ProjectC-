using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess;
using Oracle.ManagedDataAccess.Client;

namespace ProiectBD
{
    class Administrare
    {
        public const int FIRST_TABLE = 0;

        static private Conection conn = new Conection();
        public static string AddFurnizor( string Denumire)
        {
            return Conection.ExecuteNonQuery("INSERT INTO Furnizor(id,denumire) values (sequence_id.nextval,:Denumire)",
                CommandType.Text,
                  new Oracle.ManagedDataAccess.Client.OracleParameter(":Denumire", OracleDbType.Varchar2, Denumire, ParameterDirection.Input));
        }
        public static string AddMateriePrima(string denumire, int cantitate, string um, string id_furnizor)
        {
            return Conection.ExecuteNonQuery("INSERT INTO MateriePrima(id,denumire,cantitate,um,id_furnizor) values (Id_materierima.nextval,:Denumire,:Cantitate,:UM,:ID_Furnizor)",
                CommandType.Text,
                  new Oracle.ManagedDataAccess.Client.OracleParameter(":Denumire", OracleDbType.Varchar2, denumire, ParameterDirection.Input),
                   new Oracle.ManagedDataAccess.Client.OracleParameter(":Cantitate", OracleDbType.Varchar2, cantitate, ParameterDirection.Input),
                  new Oracle.ManagedDataAccess.Client.OracleParameter(":UM", OracleDbType.Varchar2, um, ParameterDirection.Input),
                 new Oracle.ManagedDataAccess.Client.OracleParameter(":ID_Furnizor", OracleDbType.Varchar2, id_furnizor, ParameterDirection.Input)
                  );

        }
        public static string AddProdusFinit(string denumire, int cantitate, int pret, string tva,string id_reteta)
        {
            return Conection.ExecuteNonQuery("INSERT INTO Stocprodusfinit(id,denumire,cantitate,pret,tva,id_reteta) values (idprodusfinit.nextval,:Denumire,:Cantitate,:pret,:tva,:id_reteta)",
                CommandType.Text,
                  new Oracle.ManagedDataAccess.Client.OracleParameter(":Denumire", OracleDbType.Varchar2, denumire, ParameterDirection.Input),
                   new Oracle.ManagedDataAccess.Client.OracleParameter(":Cantitate", OracleDbType.Varchar2, cantitate, ParameterDirection.Input),
                  new Oracle.ManagedDataAccess.Client.OracleParameter(":pret", OracleDbType.Varchar2, pret, ParameterDirection.Input),
                 new Oracle.ManagedDataAccess.Client.OracleParameter(":tva", OracleDbType.Varchar2, tva, ParameterDirection.Input),
               new Oracle.ManagedDataAccess.Client.OracleParameter(":id_reteta", OracleDbType.Varchar2,id_reteta, ParameterDirection.Input)

                  );

        }

        public static string AddProduseReteta(string ID_reteta,string ID_produs,int Cantitate, string Um)
        {
            return Conection.ExecuteNonQuery("INSERT INTO legatura(Id_reteta,ID_Produsmaterieprima,cantitate,um)  values (:ID_reteta,:ID_produs,:Cantitate,:Um)",
                CommandType.Text,
                  new Oracle.ManagedDataAccess.Client.OracleParameter(":ID_reteta", OracleDbType.Varchar2, ID_reteta, ParameterDirection.Input),
                  new Oracle.ManagedDataAccess.Client.OracleParameter(":ID_Produs", OracleDbType.Varchar2, ID_produs, ParameterDirection.Input),
                  new Oracle.ManagedDataAccess.Client.OracleParameter(":Cantitate", OracleDbType.Varchar2, Cantitate, ParameterDirection.Input),
                 new Oracle.ManagedDataAccess.Client.OracleParameter(":Um", OracleDbType.Varchar2,Um, ParameterDirection.Input)


                  );

        }
       
        public static string AddReteta(string Nume)
        {
            return Conection.ExecuteNonQuery("INSERT INTO Reteta(id,denumire) values (id_reteta.nextval,:Nume)",
                CommandType.Text,
                  new Oracle.ManagedDataAccess.Client.OracleParameter(":Nume", OracleDbType.Varchar2 ,Nume, ParameterDirection.Input)
                   
                  );

        }
        public static string EditCantitate(int cantitate,string denumire, string Id_furnizor)
        {
            var result = Conection.ExecuteNonQuery("UPDATE MateriePrima set cantitate=cantitate + "+cantitate +"where denumire='"+denumire+"' and id_furnizor='"+Id_furnizor+"'", CommandType.Text); ;

            if (result == "OK")
            {
                return "OK";
            }
            return "";
        }
        

        public static string EditMaterie(MateriePrima m)
        {
            var result = Conection.ExecuteNonQuery("UPDATE MateriePrima set denumire='" + m.Denumire.ToUpper() + "', cantitate='" + m.Cantitate + "', um='" + m.Um.ToUpper() + "' where id='" + m.ID+"'", CommandType.Text);

            if (result == "OK")
            {
                return "OK";
            }

            return "";
        }
        public static string Editreteta(Reteta r)
        {
            var result = Conection.ExecuteNonQuery("UPDATE reteta set denumire='" + r.Nume_reteta.ToUpper() + "' where ID='"+r.ID+"'", CommandType.Text);

            if (result == "OK")
            {
                return "OK";
            }
            return "";
        }
        
        public static string EditStoc(int nrproduse, string id_reteta, int cantitate,string id_produs )
        {

            var result = Conection.ExecuteNonQuery("UPDATE MateriePrima set cantitate = cantitate-(" + nrproduse+"*"+cantitate + ") where id in(select id_produsmaterieprima from legatura l where l.id_reteta= "+id_reteta+" and l.id_produsmaterieprima="+id_produs+")", CommandType.Text);
           // MessageBox.Show(x);
            if (result == "OK")
            {

                return "OK";
                
            }
            return "";
        }
            public static void DeleteFurnizor(int id)
        {
            var conn = Conection.ExecuteNonQuery("Delete from Furnizor WHERE id=" +id, CommandType.Text);
        }
        public static void DeleteReteta(int id)
        {
            var conn = Conection.ExecuteNonQuery("Delete from Reteta WHERE id=" + id, CommandType.Text);
        }
        public static void DeleteProdusReteta(int num, int num1)
        {
            var conn = Conection.ExecuteNonQuery("Delete from legatura where  id_reteta=" + num+ "and id_produsmaterieprima="+num1+"", CommandType.Text);
        }
        public static void DeleteProdusFinit(int id)
        {
            var conn = Conection.ExecuteNonQuery("Delete from stocprodusfinit  WHERE id=" + id+"", CommandType.Text);


        }
        public static void DeleteProdus(string denumire)
        {
            var conn = Conection.ExecuteNonQuery("Delete from MateriePrima WHERE denumire='" + denumire+"'", CommandType.Text);
        }
        


        public static List<Furnizor> GetFurnizori()
        {

            List<Furnizor> listFurnizor = new List<Furnizor>();
            var conn = Conection.ExecuteDataSet("SELECT ID,denumire from Furnizor ", CommandType.Text);

            foreach (DataRow line in conn.Tables[FIRST_TABLE].Rows)
            {

                listFurnizor.Add(new Furnizor(line));
            }

            return listFurnizor;
        }
        public static List<Legatura> GetCantitate(string id)
        {

            List<Legatura> list = new List<Legatura>();
            var conn = Conection.ExecuteDataSet("SELECT id_reteta,cantitate,id_produsmaterieprima from Legatura where id_reteta='"+id+"'", CommandType.Text);

            foreach (DataRow line in conn.Tables[FIRST_TABLE].Rows)
            {

                list.Add(new Legatura(line));
            }

            return list;
        }

        public static MateriePrima GetDenumireMaterie(string Denumire,string Id_furnizor)
        {

            MateriePrima m;
            var conn = Conection.ExecuteDataSet("SELECT ID,denumire from MATERIEPRIMA where denumire='"+Denumire.ToUpper()+"' and id_furnizor='"+Id_furnizor+"'", CommandType.Text);
            m = new MateriePrima(conn.Tables[FIRST_TABLE].Rows);
            return m;
        }
        public static MateriePrima GetIDMaterieprima(string id)
        {

            MateriePrima m;
            var conn = Conection.ExecuteDataSet("SELECT * from MATERIEPRIMA  where id='"+id+"'", CommandType.Text);
            m = new MateriePrima(conn.Tables[FIRST_TABLE].Rows[0]);
            return m;
        }
        public static Reteta GetIDReteta(string denumire)
        {
            Reteta m;
            var conn = Conection.ExecuteDataSet("SELECT * from reteta  where denumire='" + denumire + "'", CommandType.Text);
            m = new Reteta(conn.Tables[FIRST_TABLE].Rows[0]);
            return m;
        }
       

        public static MateriePrima GetStocMateriePrima(int id)
        {

            MateriePrima m;
            var conn = Conection.ExecuteDataSet("SELECT * from MATERIEPRIMA where id='"+id+ "'", CommandType.Text);
            m = new MateriePrima(conn.Tables[FIRST_TABLE].Rows[0]);
            return m;
        }
        public static List<MateriePrima> GetMaterie()
        {

            List<MateriePrima> listMaterie = new List<MateriePrima>();
            var conn = Conection.ExecuteDataSet("SELECT ID,denumire,cantitate, id_furnizor ,um from MateriePrima ", CommandType.Text);

            foreach (DataRow line in conn.Tables[FIRST_TABLE].Rows)
            {

                listMaterie.Add(new MateriePrima(line));
            }

            return listMaterie;
        }
        public static List<Produs> GetProdus()
        {

            List<Produs> listMaterie = new List<Produs>();
            var conn = Conection.ExecuteDataSet("SELECT * from stocprodusfinit ", CommandType.Text);

            foreach (DataRow line in conn.Tables[FIRST_TABLE].Rows)
            {

                listMaterie.Add(new Produs(line));
            }

            return listMaterie;
        }

        public static List<Reteta> GetReteta()
        {
            List<Reteta> listReteta = new List<Reteta>();
            string sql = "SELECT ID,denumire from reteta ";
            var conn = Conection.ExecuteDataSet(sql, CommandType.Text);
            foreach (DataRow line in conn.Tables[FIRST_TABLE].Rows)
            {
                listReteta.Add(new Reteta(line));
            }

            return listReteta;
        }



    }
}
