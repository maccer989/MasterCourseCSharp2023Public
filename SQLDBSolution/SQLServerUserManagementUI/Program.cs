//From ChatGPT combined with direction form TimCorey SQL Serevr class

using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
//Console.WriteLine(GetConnectionString());

SqlCrud sql = new SqlCrud(GetConnectionString());//gets a connection string for database to instance sql of class SqlCrud

//ReadAllContacts(sql);

//CreateUser(sql);
UpdateUser(sql);


Console.WriteLine("Done processing");
Console.ReadLine();


//return connection string to database
static string GetConnectionString(string connectionStringName = "Default")
{
    string output = "";

    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");
    
    var config = builder.Build();

    output = config.GetConnectionString(connectionStringName);

    return output;


}

static void ReadAllContacts(SqlCrud sql)
{
    var rows = sql.GetAllUsers();//rows is a list of BasicUserModels

    foreach (var row in rows)
    {
        Console.WriteLine($"{row.Id}:{row.FirstName} {row.LastName} {row.Email}");
    }
}


void CreateUser(SqlCrud sql)
{
    BasicUserModel user = new BasicUserModel();
    user.FirstName = "Ian";
    user.LastName = "Smith";
    user.Email = "ISmith@hotmail.co.uk";
    sql.CreateUser(user);
    ReadAllContacts(sql);
}

void UpdateUser(SqlCrud sql)
{
    BasicUserModel user = new BasicUserModel();
    user.Id = 1;
    user.FirstName = "Jon";
    user.LastName = "Holmes";
    user.Email = "JHolmes@hotmail.co.uk";
    sql.UpdateUser(user);
    ReadAllContacts(sql);
}
