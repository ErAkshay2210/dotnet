
using System;
using System.IO;
using TransFLowerException;
using Collections;


string fpath =@"D:\Test.txt";
StreamReader sr =new StreamReader(fpath);

try
{
    string txt;

    while ((txt = sr.ReadLine())!=null)
    {
         System.Console.WriteLine(txt);

    }

}
catch(Exception ex)
{
     System.Console.WriteLine("Exception:{0}",ex.Message);
}
finally
{
    if (sr !=null)
    {
       sr.Close();  

    }
}
string name ="Akshay";
if(string.IsNullOrEmpty(name))
{
    throw new TutlaneCustomeException("Name is Empaty");
}
else 
{
    System.Console.WriteLine("Name:"+name);

}
 
 using CollectionDemo;
 
   
    
    int [] numbers= {25,45,75,85};
    int[] marks = new int[5] { 76, 67, 78, 65, 45 };
    string[] trainers = { "Prachi", "Kishori", "Madhura", "Nilesh", "Amit" };

    //Arrays of object of type Student
    Student[] students = {
                            new Student{ BirthDate = new DateTime(1998, 3, 12),
                                            Name = "Akshay Girmal",
                                            Location = "Mumbai",
                                            Id = 45
                            },
                            new Student{ BirthDate = new DateTime(1992, 6, 22),
                                            Name = "Ramya Datta",
                                            Location = "Kolkatta",
                                            Id = 47
                            },
                            new Student{ BirthDate = new DateTime(1988, 3, 12),
                                            Name = "Manisha Patil",
                                            Location = "Pune",
                                            Id = 15
                            },

    };
    foreach( string Id in trainers )
    {
       // Console.WriteLine(name);
        System.Console.WriteLine(Id);
    }
    foreach ( Student s in students )
    {
        Console.WriteLine(s.Id + "  " + s.Name + "  " + s.Location);
    }





    Team T =new Team("India");
    T.ToString();

    System.Console.WriteLine(T);
    
    
  
  





