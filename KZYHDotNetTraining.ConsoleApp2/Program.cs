using KZYHDotNetTraining.Database.Models;

Console.WriteLine("Hello, World!");

AppDbContext db = new AppDbContext();
var lst = db.TblBlogs.ToList();

foreach (var item in lst)
{
    Console.WriteLine($"BlogId: {item.BlogId}, BlogTitle: {item.BlogTitle}, BlogAuthor: {item.BlogAuthor}");
}