using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
//Console.ReadLine();
//Console.ReadKey();

//C# <=> Database

//ADO.NET   /old
//Dapper    (ORM) object relational mapping
//EFCore    /Entity Framework Core (ORM) 

//C# => sql query => database

//nuget (package)

string connectionString = "Data Source=.;Initial Catalog=DotNetTraining;User ID=sa;Password=sasa@123";
Console.WriteLine("Connection String: " + connectionString);
SqlConnection connection = new SqlConnection(connectionString);

Console.WriteLine("Connection Opening...");
connection.Open();
Console.WriteLine("Connection Opened.");

string query = @"SELECT [BlogId]
      ,[BlogTitle]
      ,[BlogAuthor]
      ,[BlogContent]
      ,[DeleteFlag]
  FROM [dbo].[Tbl_Blog]";
SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);

//dt = adapter.Fill();

SqlDataReader reader = cmd.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine(reader["BlogId"]);
    Console.WriteLine(reader["BlogTitle"]);
    Console.WriteLine(reader["BlogAuthor"]);
    Console.WriteLine(reader["BlogContent"]);
    Console.WriteLine(reader["DeleteFlag"]);


}


//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);

//}

Console.WriteLine("Connection Closing...");
connection.Close();
Console.WriteLine("connection Closed.");

//DataSet
//DataTable
//DataRow
//DataColumn

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);

//}

