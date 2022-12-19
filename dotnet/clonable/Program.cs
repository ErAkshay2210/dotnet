
using TFL;


Shipper shp1 =new Shipper (23," FedEx");
Shipper shp2 =new Shipper (10," UOS");
Shipper shp3 =new Shipper (15," DHL");
Shipper shp5 =new Shipper (14,"  GEMLIT");


//Shipper  shp4 =shp1;

Shipper shp4 =(Shipper)shp2.Clone();

System.Console.WriteLine(shp1);

System.Console.WriteLine(shp2);
System.Console.WriteLine(shp3);
System.Console.WriteLine(shp4);
System.Console.WriteLine(shp5);

