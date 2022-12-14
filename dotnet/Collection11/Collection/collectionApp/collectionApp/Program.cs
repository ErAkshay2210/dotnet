

using TAP;
//int sum=45;
//string fullName= "Rajiv Pande";
//array  of int 
//Single Dimension Array
/*int [] numbers= {45,65,76,23,76,47};

foreach( int number in numbers){
    Console.WriteLine(number);
}
*/

//array of string objects
/*
string [] trainers={
    "Prachi",
     "Mangesh", 
     "Ravi",
      "Sachin"
};

for( int i=0 ;i<=trainers.Length-1;i++){
    Console.WriteLine(trainers[i]);
}


foreach(string name in trainers){
    Console.WriteLine(name);
}
*/

/*
Student [] students={
    new Student{
        BirthDate = new DateTime(1998, 3, 12),
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
}
};

foreach( Student currentStudent in students){
     Console.WriteLine(currentStudent.Id + "  " + currentStudent.Name + "  " +currentStudent.Location);
}
*/


//Multi Dimensional Array
//Rectangular Array
//row , column
/*
int [,] mtrx=new int[3,3]{
    {10,20,30},
    {56,76,12},
    {23,45,87}
};

Console.WriteLine("Rectangule Array Elements");

for(int i=0;i<3;i++){
    Console.WriteLine("\n");
    for(int j=0;j<3;j++){
          Console.Write(mtrx[i, j] + "\t");
    }
}

*/
/*
int [,] monthTimeSheet=new int [4,7]{
    {6,5,8,3,4,5,4},
    {4,7,5,4,4,6,7},
    {8,7,6,8,7,6,9},
    {2,6,8,7,9,6,5}
};

Console.WriteLine( "My Montly working hours Timesheet");

string [] days={"Mon", "Tues", "Wed", "Thurs", "Fri","Sat", "Sun"};

for(int i=0;i<7;i++){

    Console.Write(days[i] + "\t");
}
string []weeks= {"Week1", "week2", "week3", "week4"};

for(int week=0;week<4;week++){
    Console.WriteLine("\n");
    Console.WriteLine(weeks[week]);
    for(int day=0;day<7;day++){
          Console.Write(monthTimeSheet[week, day] + "\t");
    }
}
*/





//Array of stnd


Student[] students ={ new Student(01,"Vedant","pune"," Gsm"),
                      new Student (02,"Vaibhav","Pune"," DY Patil clg")
                      
                      };
    

      foreach(Student TheStudent in students)
      {
         System.Console.WriteLine(TheStudent.getId()+" , "+TheStudent.getName()+" , "+TheStudent.getLocation()+" , "+TheStudent.getClass()
         );
      }
        

    
          

         
    
