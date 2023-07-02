using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqlCrud
    {
        private readonly string _connectionString;//stored for legnth of time class exists
        private SqlDataAccess db = new SqlDataAccess();

        //talks to SQLdta ACees class but needs a conenction string
        public SqlCrud(string connectionString) 
        {
            _connectionString = connectionString;
        }    

        public List<BasicUserModel> GetAllUsers() 
        {
            //what query will we write to get all contacts
            //Create a sql statement
            string sql = "select Id, FirstName, LastName, Email from dbo.Users";
            //call to load data into model type and has no paramters
            return db.LoadData<BasicUserModel, dynamic>(sql, new { }, _connectionString);//return a list of BasicUserModel U will be parameters, dynamic means can be almost anything a new{} anonymous object
            
        }

        public void CreateUser(BasicUserModel user)
        {
            string sql = "insert into dbo.Users (FirstName, LastName, Email) values (@FirstName, @LastName, @Email);";
            db.SaveData(sql, new {user.FirstName, user.LastName, user.Email}, _connectionString);
         
        }

        public void UpdateUser(BasicUserModel user)
        {
            string sql = "update dbo.Users set FirstName = @FirstName, LastName = @LastName, Email = @Email where Id = @Id;";
            db.SaveData(sql, user, _connectionString);

        }

        //public void RemoveEmailFromUser(int userId, string email)
        //{
        //    string sql = "select Id, FirstName, lastName,Email from dbo.Users set FirstName = @FirstName, LastName = @LastName, Email = @Email where Id = @Id;";
        //    db.SaveData(sql, user, _connectionString);

        //}
    }
}
