using System.Collections.Generic;
using TFLCollections;

List<int> marks=new List<int>();
marks.Add(45);
marks.Add(67);
marks.Add(88);

foreach( int number in marks){
    Console.WriteLine(number);
}

List<Student> allStudents=new List<Student>();
allStudents.Add(new Student{ Id=12, Name="Rajan", Location="Manchar"});
allStudents.Add(new Student{ Id=13, Name="Manisha", Location="Ghodegaon"});
allStudents.Add(new Student{ Id=14, Name="Nuntan", Location="Khed"});
allStudents.Add(new Student{ Id=15, Name="Ajay", Location="Narayangaon"});

Console.WriteLine( "List of Students");
foreach( Student s in allStudents){
    Console.WriteLine(s);
}


Console.WriteLine( "\n\nList of Employees");
List<Employee> employees=new List<Employee>();
employees.Add(new Employee(56,"Sameer", "Rokade"));
employees.Add(new Employee(57,"Jeevan", "Jadhav"));
employees.Add(new Employee(56,"Sarika", "Bhor"));
employees.Add(new Employee(59,"Jayanti", "Shevade"));
employees.Add(new Employee(60,"Ram", "Patil"));
employees.Add(new Employee(61,"Manoj", "Shinde"));

foreach(  emp in employees){
    Console.WriteLine(emp);
}