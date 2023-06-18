using System.Collections.Generic;
using BOL;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/aboutus", () => "Transflower Learning Pvt. Ltd.");
app.MapGet("/contactus", () => "RR Store, Tel.No:- 12345678910");

List<Product> products = new List<Product>();
products.Add(new Product { Id=1, Title="Apple", Description="IPhone 14pro", UnitPrice=140000, Quntity=15 });
products.Add(new Product { Id=2, Title="Sumsung", Description="S22 Utra", UnitPrice=100000, Quntity=5 });
products.Add(new Product { Id=3, Title="Vivo", Description="X22", UnitPrice=80000, Quntity=2 });
products.Add(new Product { Id=4, Title="Oppo", Description="Remo 8", UnitPrice=40000, Quntity=10 });

app.MapGet("/api/product", () =>products);
app.MapGet("/api/product/{id}", () => DBManager.GetById(4));


app.MapPut("/api/product/{id}",(int id , Product prod) =>
{
         var existingproduct = new Product {Id=id ,Title="Motorola",Description="Foldeble Mobile",UnitPrice=23000,Quntity=15};
         if (existingproduct is null) return Results.NotFound();
         existingproduct.Title = prod.Title;
         existingproduct.Description=prod.Description;
         existingproduct.UnitPrice=prod.UnitPrice;
         existingproduct.Quntity=prod.Quntity;
         return Results.NoContent();

}  );


app.Run();
