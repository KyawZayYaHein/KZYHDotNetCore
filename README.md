# KZYHDotNetTraining

//DTO => Data Transfer Object(getter setter)


**AsNoTracking

"select * from tbl_blog"
select
both commit and uncommit datas

when someone is doing
update
insert
etc.

the select statement is waiting for the transaction to be completed.

we can use
"select * from tbl_blog with (nolock)"
to prevent this. but we'll not get real time data and not updated data.


*Oracle is unique, it only select commit datas
*That "With (nolock)" is called as no tracking in C#

-----

efcore database first(manual, auto)/ code first	// we don't do code first

dotnet ef dbcontext scaffold "Server=.;Database=DotNetTraining;User Id=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -c AppDbContext -t Tbl_Name -f
