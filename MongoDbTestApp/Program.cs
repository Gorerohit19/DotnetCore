using MongoDbTest;
using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


int choise;
do{
   Console.WriteLine("Welcome to Transflower Learning Pvt. Ltd.");
   Console.WriteLine("-------------------------------------------------------------");
   DisplayManager.ShowManu();
   Console.WriteLine("**************************************************************");
   Console.WriteLine("Tap Student Operations");
   choise = int.Parse(Console.ReadLine());
    switch(choise)
    {
        case 1: 
            DisplayManager.ShowAllCollection(); 
        break;

        

    }

    
}
while(choise != 0);
