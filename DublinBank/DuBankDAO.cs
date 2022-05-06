using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace DublinBank
{
    internal class DuBankDAO
    {
        //Global Connection
        private SqlConnection connection;

        //constructor
        public DuBankDAO() 
        {
            connection = new SqlConnection
            {
                ConnectionString = "Data Source=DESKTOP-RRB1RS4;Initial Catalog=DublinBank;Integrated Security=True"

            };        
        }
        public bool SaveUser(DuBank duBank) 
        {
            string sql = "INSERT INTO Customer " +
                          "(name, address, phoneNo, balance) " +
                         " VALUES(@name, @address, @phoneNo, @balance); " +
                         "INSERT INTO Login " +
                         "(password) " +
                          "VALUES(@password) ";
            try 
            {
                SqlCommand cmd = new SqlCommand(sql, connection);
                
                SetUpCommandParameters(cmd, duBank);
                
                connection.Open();

            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        
        }
        private void SetUpCommandParameters(SqlCommand cmd, DuBank duBank) 
        {
            cmd.Parameters.Add(new SqlParameter 
            { 
                ParameterName = "@name",
                Value = duBank.Name,
                SqlDbType = SqlDbType.VarChar,
                Size = 60

            });
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@address",
                Value = duBank.Address,
                SqlDbType = SqlDbType.VarChar,
                Size = 80

            });
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@phoneNo",
                Value = duBank.PhoneNo,
                SqlDbType = SqlDbType.VarChar,
                Size = 12

            });
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@balance",
                Value = duBank.Balance,
                SqlDbType = SqlDbType.VarChar,
                Size = 20

            });
            cmd.Parameters.Add(new SqlParameter
            {
                ParameterName = "@password",
                Value = duBank.Password,
                SqlDbType = SqlDbType.VarChar,
                Size = 8

            });


        }
    }
}
