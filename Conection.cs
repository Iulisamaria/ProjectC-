using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace ProiectBD
{
    class Conection
    {
        private const int EROARE_LA_EXECUTIE = 0;
        private OracleConnection conn;
        private string OracleServer = "Data Source=(DESCRIPTION=(ADDRESS_LIST="
              + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
              + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
              + "User Id=iulisa;Password=123456;"; // change it with your username and password database server
        public bool Open()
        {
            try
            {
                conn = new OracleConnection(OracleServer);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }
        public static DataSet ExecuteDataSet(string sql, CommandType cmdType, params OracleParameter[] parameters)
        {
            using (DataSet ds = new DataSet())
            using (OracleConnection conn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST="
              + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
              + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
              + "User Id=iulisa;Password=123456;"))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    try
                    {
                        new OracleDataAdapter(cmd).Fill(ds);
                    }
                    catch (OracleException ex)
                    {
                        //salveaza exceptii in fisiere log
                    }
                    return ds;
                }
            }
        }
        public OracleDataReader ExecuteReader(string sql)
        {
            try
            {
                OracleDataReader reader;
                OracleCommand cmd = new OracleCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static DataSet ExecuteDataSet2(string sql, CommandType cmdType, params OracleParameter[] parameters)
        {
            using (DataSet ds = new DataSet())
            using (OracleConnection conn = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS_LIST = "
              + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
              + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
              + "User Id=iulisa;Password=123456;"))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    try
                    {
                        new OracleDataAdapter(cmd).Fill(ds);
                    }
                    catch (OracleException ex)
                    {
                        //salveaza exceptii in fisiere log
                    }
                    return ds;
                }
            }
        }
        public static string ExecuteNonQuery(string sql, CommandType cmdType, params OracleParameter[] parameters)
        {
            int rezult = EROARE_LA_EXECUTIE;
            string error = "";

            using (OracleConnection conn = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS_LIST = "
              + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
              + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=ORCL)));"
              + "User Id=iulisa;Password=123456;"))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.CommandType = cmdType;
                    foreach (var item in parameters)
                    {
                        cmd.Parameters.Add(item);
                    }

                    try
                    {

                        cmd.Connection.Open();
                        rezult = cmd.ExecuteNonQuery();
                        if (rezult == 1)
                            return "OK";
                    }
                    catch (OracleException ex)
                    {
                        Console.WriteLine(ex.ToString());
                        error = ex.Message.ToString();
                        //salveaza exceptii in fisiere log
                    }
                }
            }
            return error;
            //return Convert.ToBoolean(rezult);
        }
    }
}
