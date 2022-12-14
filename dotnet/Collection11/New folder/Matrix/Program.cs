using  Sales;


List<Vehicle>vehicles =new List<Vehicle>();

vehicles.Add(new Vehicle(465465, "i20",400000,"Abhi Bhosale","8789645986","abhi@gmail.com"));
vehicles.Add(new Vehicle(554645, "Wagnor",200000,"Ganesh Ladke","98654575456","Ganesh@gmail.com"));
vehicles.Add(new Vehicle(455645, "i10",150000,"Naresh Patil","75959645986","Naresh@gmail.com"));
vehicles.Add(new Vehicle(5464745, "alto",89000,"Nitin Nalawade","75989645986","Nitin@gmail.com"));


foreach (Vehicle car in vehicles)
{
    System.Console.WriteLine(car);
}

System.Console.WriteLine("\n contains(\"454545\"):{0}",
vehicles.Contains(new Vehicle{RegistartionNumber=4545, ModelName=""}));

System.Console.WriteLine("\nInsert(4856,\"Verna, 750000\")");
vehicles.Insert(2,new Vehicle(){RegistartionNumber=4585,ModelName="Verna", Price=750000, OwnerName="Omkar kad",ContactNumber="9862456585"});


foreach (Vehicle car in vehicles)
{
    System.Console.WriteLine(car);
}

//remove

vehicles.Remove(new Vehicle(){RegistartionNumber =5464745, ModelName="alto",Price=89000,OwnerName="Nitin Nalawade",ContactNumber="75989645986",Email="Nitin@gmail.com"});

System.Console.WriteLine();
foreach (Vehicle car in vehicles)
{
    System.Console.WriteLine(car);
}



















































