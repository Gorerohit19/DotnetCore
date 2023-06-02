using TFL;

Shipper shp1 = new Shipper(23,"FedEx");
Shipper shp2 = new Shipper(10,"UPS");
Shipper shp3 = new Shipper(30,"DHL");

Console.WriteLine(shp1);
Console.WriteLine(shp2);
Console.WriteLine(shp3);
//shp1, shp2 , shp3  , shp4   they are references
//refernces  store address of objects   which are created on heap

//references are copied 
//shallow copy
//Shipper  shp4=shp1;

//deep copy
//creating another instance with same data
Shipper shp4 =(Shipper)shp1.Clone();

Console.WriteLine(shp1);
Console.WriteLine(shp4);

//Adding new name in shp1
shp1.name="Palande Couries";
Console.WriteLine(shp1);
Console.WriteLine(shp4);