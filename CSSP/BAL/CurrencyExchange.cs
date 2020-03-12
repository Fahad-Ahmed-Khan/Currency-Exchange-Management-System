using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using WindowsFormsApp1.DAL;

namespace BAL
{
    public class CurrencyExchange
    {

        DbOperations dbOperation = new DbOperations();

        

        public int addTransaction(string table, BEL.Transaction transaction)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            if (table=="sell")
                cmd.CommandText = @"INSERT INTO SellTable ( dolars, ExchangeRate, pesos, transactionDate )
                                Values(?,?,?,?)";
            else
                cmd.CommandText = @"INSERT INTO BuyTable ( dolars, ExchangeRate, pesos, transactionDate )
                                Values(?,?,?,?)";

            cmd.Parameters.Add("?", OleDbType.Currency, 100).Value = transaction.dolars;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = transaction.exchangeRate;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = transaction.pesos;
            cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now.ToShortDateString();


            return dbOperation.ExecuteNonQuery(cmd);
        }



        internal object getallRecords(string table)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            if(table=="sell")
                cmd.CommandText = @"SELECT * FROM SellTable order by TransactionID desc";
            else
                cmd.CommandText = @"SELECT * FROM BuyTable order by TransactionID desc";

            return dbOperation.ExecuteReader(cmd);
        }

        public BEL.Transaction getExchangeRate(string table)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text; if (table == "buy")
                cmd.CommandText = @"SELECT * FROM ExchangeRates Where ID = 1";
            else
                cmd.CommandText = @"SELECT * FROM ExchangeRates Where ID = 2";

            DataTable dt = dbOperation.ExecuteReader(cmd);
            return new BEL.Transaction()
            {
                exchangeRate = Convert.ToDouble(dt.Rows[0][1]),
                lowerLimit = Convert.ToDouble(dt.Rows[0][2]),
                upperLimit = Convert.ToDouble(dt.Rows[0][3]),
            };
        }

        internal int updateExchangeRates(int ID, Transaction exchangeRates)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"UPDATE ExchangeRates SET ExchangeRate = ?, lowerlimit = ?, upperlimit = ?
                                    WHERE ID =?;";
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = exchangeRates.exchangeRate;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = exchangeRates.lowerLimit;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = exchangeRates.upperLimit;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = ID;

            return dbOperation.ExecuteNonQuery(cmd);
        }

        public int deleteEmployee(int EmpId)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete FROM Employees Where EmpId = ?;";
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = EmpId;
            return dbOperation.ExecuteNonQuery(cmd);
        }
        
        public int getTransactionID(string table)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text; if (table == "buy")
                cmd.CommandText = @"SELECT max(TransactionID) FROM BuyTable";
            else
                cmd.CommandText = @"SELECT max(TransactionID) FROM SellTable";

            return Convert.ToInt32(dbOperation.ExecuteScalar(cmd));
            
        }

        //public int updateEmployee(BEL.Transaction employee)
        //{

        //    OleDbCommand cmd = new OleDbCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = @"UPDATE Employees SET EmpName = ?, EmpDob = ?, EmpDept = ?
        //                        WHERE EmpId =?;";
        //    cmd.Parameters.Add("?", OleDbType.VarChar, 100).Value = employee.Name;
        //    cmd.Parameters.Add("?", OleDbType.Date).Value = employee.Dob;
        //    cmd.Parameters.Add("?", OleDbType.Numeric).Value = employee.DepartmentID;
        //    cmd.Parameters.Add("?", OleDbType.Numeric).Value = employee.ID;

        //    return dbOperation.ExecuteNonQuery(cmd);

        //}

    }
}
