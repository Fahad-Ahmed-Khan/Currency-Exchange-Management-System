using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAL
{
    public class DbOperations
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\database\\CEDB.mdb");


        public OleDbConnection getCon()
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                con.Close();
            }
            return con;
        }

        public int ExecuteNonQuery(OleDbCommand cmd)
        {
            try
            {
                cmd.Connection = getCon();
                int affectedRows = -1;
                affectedRows = cmd.ExecuteNonQuery();
                con.Close();
                return affectedRows;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                con.Close();
                return -1;
            }

        }

        public object ExecuteScalar(OleDbCommand cmd)
        {
            try
            {
                cmd.Connection = getCon();
                object obj = -1;
                obj = cmd.ExecuteScalar();
                con.Close();
                return obj;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                con.Close();
                return -1;
            }
        }

        public DataTable ExecuteReader(OleDbCommand cmd)
        {
            try
            {
                cmd.Connection = getCon();
                DataTable dt = new DataTable();
                OleDbDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                return dt;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                con.Close();
                return null;
            }
        }
    }
}
