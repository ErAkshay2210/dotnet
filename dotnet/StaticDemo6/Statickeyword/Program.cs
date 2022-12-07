
using Trainning;

Student std= new Student();
Student std2=new Student(02,"Vaibhav","Mechhanical","Pune");
Student std3=new Student (03,"Abhijit","Civil","Pune","9921337459");

Console.WriteLine(std);
Console.WriteLine(std2);
Console.WriteLine(std3);



std.ShowStatus();
std2.ShowStatus();
std3.ShowStatus();



int noOfInstances=Student.GetCount(); 
Console.WriteLine("No of objects of Student class = {0}", noOfInstances);
System.Console.WriteLine("Done");