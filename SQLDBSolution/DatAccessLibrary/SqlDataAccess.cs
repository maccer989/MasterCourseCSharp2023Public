using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLibrary
{
    public class SqlDataAccess
    {
        //LOAD Data
        //contains 2 generics one is U contains parameters the other is the return type List <T> to create a connection
        public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
        {
            //creates an always closable connection to the database
            using (IDbConnection connection = new SqlConnection(connectionString))//sql connection to a sql server known by connectionString
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();//dapper ORM uses query database xonenction here is my query sqlstatement with limiters eg ID
                return rows;//Type T is model type whihc is a list of T - model type for rows in strongly typed models so they can be returned
            }

        }

        //SAVE data
        public void SaveData<T>(string sqlStatement, T parameters, string connectionString)//data is passed in as type T
        {
            //creates an always closable connection to the database
            using (IDbConnection connection = new SqlConnection(connectionString))//sql connection to a sql server known by connectionString
            {
                connection.Execute(sqlStatement, parameters);
            }

        }
    }
}
