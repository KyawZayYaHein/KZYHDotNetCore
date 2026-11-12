using Dapper;
using KZYHDotNetTraining.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace KZYHDotNetTraining.ConsoleApp
{
    public class DapperExample
    {
        private readonly string _connectionString = "Data Source=.;Initial Catalog=DotNetTraining;User Id=sa;Password=sasa@123";
        public void Read()
        {
            // using(IDbConnection db= new SqlConnection(_connectionString))
            //{
            //    string query = "select * from tbl_blog where DeleteFlag=0;";
            //    var lst= db.Query(query).ToList();
            //    foreach (var item in lst)
            //    {
            //        Console.WriteLine(item.BlogId);
            //        Console.WriteLine(item.BlogTitle);
            //        Console.WriteLine(item.BlogAuthor);
            //        Console.WriteLine(item.BlogContent);
            //    }
            //}

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string query = "select * from tbl_blog where DeleteFlag=0;";
                var lst = db.Query<BlogDataModel>(query).ToList();
                foreach (var item in lst)
                {
                    Console.WriteLine(item.BlogId);
                    Console.WriteLine(item.BlogTitle);
                    Console.WriteLine(item.BlogAuthor);
                    Console.WriteLine(item.BlogContent);
                }
            }

            //DTO => Data Transfer Object(getter setter)
        }

        public void Create(string title, string author, string content)
        {
            string query = $@"INSERT INTO [dbo].[Tbl_Blog]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent]
           ,[DeleteFlag])
     VALUES
           (@BlogTitle
           ,@BlogAuthor
           ,@BlogContent
           ,0)";

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                int result = db.Execute(query, new
                {
                    BlogTitle = title,
                    BlogAuthor = author,
                    BlogContent = content
                });
                Console.WriteLine(result == 1 ? "Saving Successful" : "Saving Failed");
            }
        }
    }
}
