using KZYHDotNetTraining.ConsoleApp;
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

AdoDotNetExample adoDotNetExample=new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create();
//adoDotNetExample.Edit();
//adoDotNetExample.Update();
//adoDotNetExample.Delete();

DapperExample dapperExample= new DapperExample();
//dapperExample.Read();
dapperExample.Create("asdas","dasaw","asdwfkws");


