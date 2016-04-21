using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase
{
    public class ConnectDB
    {
        IniFile ini = new IniFile("C:\\Settings.ini");
        #region Properties

        public enum ConStringType
        {
            Configuration,
            General
        }

        public SqlConnection cn;
        SqlCommand cmd;
        //DataSet ds;
        SqlDataAdapter da;
        SqlTransaction objTran;

        #endregion

        #region Connection

        /*string dbName;
        string serverName;
        string connectionString;*/

        public ConnectDB()
        {
            //serverName = "IT-G";
            //dbName = "SPS";
            //connectionString = ConfigurationManager.ConnectionStrings["workCon"].ConnectionString;
            //connectionString = string.Format("server={0}; database={1};trusted_connection=yes", serverName, dbName);
            //cn = new SqlConnection(connectionString);
            //string cnst = "Data Source=AL_G;Initial Catalog=MMS;Integrated Security=True";
            //cn = new SqlConnection(cnst);
        }

        /// <summary>
        /// Opens a connection to the database
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                cn = new SqlConnection("Data Source=" + ini.IniReadValue("dbServer", "Server") + ";Initial Catalog=" + ini.IniReadValue("dbServer", "DBName") + ";User ID=" + ini.IniReadValue("dbServer", "UID") + ";Password=" + ini.IniReadValue("dbServer", "Password") + ";Integrated Security=" + ini.IniReadValue("dbServer", "Trusted"));
                //cn = new SqlConnection("Data Source=KAKASHI\\KAKASHI;Initial Catalog=alwakala;User ID=sa;Password=183461;");
                if (cn.State != ConnectionState.Open)
                    cn.Open();
            }
            catch (Exception ex)
            {
                throw ex; //new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Closes the open connection
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch (Exception ex)
            {
                throw ex; // new Exception(ex.Message);
            }
        }

        #endregion

        #region Command Execution Methods

        /// <summary>
        ///  To Execute SQL statement that returns result in rows
        /// </summary>
        /// <param name="sqlStmt">SQL Statement</param>
        /// <returns>result rows</returns>
        public DataTable ExecuteQuery(string sqlStmt)
        {
            OpenConnection();
            // cn = new SqlConnection(connectionString);
            //cmd = new SqlCommand(sqlStmt, cn);
            da = new SqlDataAdapter(sqlStmt, cn);
            //cmd.CommandTimeout = 600;
            DataTable MyDT = new DataTable();
            try
            {


                da = new SqlDataAdapter(sqlStmt, cn);
                da.Fill(MyDT);
            }
            catch (Exception ex)
            {
                throw ex; // new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return MyDT;
        }

        public Object ExecuteModify(string sql)
        {
            Boolean flag = false;
            try
            {
                OpenConnection();
                cmd = new SqlCommand(sql, cn);
                objTran = cn.BeginTransaction();
                cmd.Transaction = objTran;
                cmd.ExecuteNonQuery();
                objTran.Commit();
                flag = true;
            }
            catch (Exception ex)
            {
                throw ex; // new Exception(ex.Message);
            }

            finally
            {
                CloseConnection();
            } return flag;
        }

        #endregion
    }
}
