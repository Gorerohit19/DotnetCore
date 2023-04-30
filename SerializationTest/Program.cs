using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SerializationTest
{
   /* [Serializable] */
    public class Product
    {
        public int Id{get; set;}
        public int Likes{get; set;}
        public string Title{get; set;}
        public string Description{get; set;}
        public string ImageURL{get; set;}
        public double UnitPrice{get; set;}
        public int Quntity{get; set;}
    }

    class Program
    {
        static void Main(string [] args)
        {
            Product theProduct = new Product();
            theProduct.Id = 1;
            theProduct.Likes = 5000;
            theProduct.Title = "IPhone";
            theProduct.Description = "Best Smart Phones";
            theProduct.ImageURL = "/images/Iphone.jpg";
            theProduct.UnitPrice = 129000;
            theProduct.Quntity = 500;

            Product theProduct1 = new Product();
            theProduct1.Id = 2;
            theProduct1.Likes = 4500;
            theProduct1.Title = "Samsung";
            theProduct1.Description = "Best Dispay Phones";
            theProduct1.ImageURL = "/images/Samsung.jpg";
            theProduct1.UnitPrice = 100000;
            theProduct1.Quntity = 400;

            List<Product> products = new List<Product>();
            products.Add(theProduct);
            products.Add(theProduct1);

            //Property Initializer Syntax
            products.Add(new Product {Id=3,Likes=6000,Title="Vivo",Description="Best Selling Phone", ImageURL="/images/Vivo.jpg",UnitPrice=50000,Quntity=1000});
            products.Add(new Product {Id=4,Likes=3000,Title="Oppo",Description="Best Selling Phone", ImageURL="/images/Oppo.jpg", UnitPrice=20000,Quntity=500});
            products.Add(new Product {Id=5,Likes=2000,Title="Xiaomi",Description="Best Budget Phone", ImageURL="/images/Xiaomi.jpg", UnitPrice=15000,Quntity=500});
            products.Add(new Product {Id=6,Likes=500,Title="Nokia",Description="Best Phone", ImageURL="/images/Nokia.jpg", UnitPrice=9000,Quntity=100});

    

            foreach(Product product in products)
            {
                Console.WriteLine($" Phones : {product.Id} : {product.Title} : {product.Description} : {product.UnitPrice} ");
            }

            /*
            // Logic For Serialization
            try
            {
                Stream stream = new FileStream("product.bin", FileMode.Create,FileAccess.Write,FileShare.None);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, products);
                stream.Close();

            }
            catch(Exception exp)
            {

            }
            finally
            {

            }

            //Logic For Deserialization
            Console.WriteLine("After Deserialization, Retrived Data ");
            try
            {
              BinaryFormatter formatter = new BinaryFormatter();
              Stream stream = new FileStream("product1.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
              List<Product> productFromFile = (List<Product>)formatter.Deserialize(stream);
              foreach(Product product in productFromFile)
              {
                Console.WriteLine($"Phone : {product.Id} : {product.Title} : {product.Description} : {product.UnitPrice}");
              }

              stream.Close();
            }
            catch(Exception exp)
            {
                Console.WriteLine("Something Went Wrong ...");
                Console.WriteLine(exp.Message);

            }
            finally
            {

            }*/

            //Json Serialiazation Logic

            try
            {
            var option = new JsonSerializerOptions {IncludeField=true};
            var productJson = JsonSerializer.Serialize<List<Product>>(products, option);
            
            string fileName = "product.json";
            File.WriteAllText(productJson, fileName);
        
            // Desrialization Logic
            string jsonString = File.ReadAllText(fileName);

            //Decoding Stream Into Objects
            Lsit<Product> jsonProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
            Console.WriteLine(" Deserializing data from json file");
            foreach(Product product in jsonProduct)
            {
             Console.WriteLine($"Phone : {product.Title} : {product.UnitPrice}");
            }
            }
            catch(Exception exp)
            {

            }
            finally 
            {

            }
        }
    }
}