using Training;
using System.Collections.Generic;
using DeviceManagement;
using Account;
using School;
using IPL;


/*
System.Console.WriteLine(" \n * Transflower Service Provider \n ");
ITTrainingServiceProvider transflower =new ITTrainingServiceProvider ();
transflower.Evaluate();
transflower.Teach();
transflower.ConductPractical();

System.Console.WriteLine(" \n GSM College Provider \n");
ITTrainingServiceProvider gsm =new ITTrainingServiceProvider();
gsm.Evaluate();
gsm.Teach();
gsm.ConductPractical();

System.Console.WriteLine("\n * Audodesk Vendor\n \t");
AutomobileTrainingServiceProvider autodesk =new AutomobileTrainingServiceProvider();
autodesk.Evaluate();
autodesk.Teach();
autodesk.ConductPractical();

System.Console.WriteLine(" \n * Hrm Core Science provider\n \t ");
CoreScienceTrainingServiceProvider hrm= new CoreScienceTrainingServiceProvider();
hrm.Evaluate();
hrm.Teach();
hrm.ConductPractical();

System.Console.WriteLine("\n * MG core science provider\n ");
CoreScienceTrainingServiceProvider mg= new CoreScienceTrainingServiceProvider();
mg.Evaluate();
mg.Teach();
mg.ConductPractical();

*/

/*
System.Console.WriteLine(" \n * Transflower Service Provider \n ");
TrainingInterface transflower =new ITTrainingServiceProvider ();
transflower.Evaluate();
transflower.Teach();
transflower.ConductPractical();

System.Console.WriteLine(" \n GSM College Provider \n");
TrainingInterface gsm =new ITTrainingServiceProvider();
gsm.Evaluate();
gsm.Teach();
gsm.ConductPractical();

System.Console.WriteLine("\n * Audodesk Vendor\n \t");
TrainingInterface autodesk =new AutomobileTrainingServiceProvider();
autodesk.Evaluate();
autodesk.Teach();
autodesk.ConductPractical();

System.Console.WriteLine(" \n * Hrm Core Science provider\n \t ");
TrainingInterface hrm= new CoreScienceTrainingServiceProvider();
hrm.Evaluate();
hrm.Teach();
hrm.ConductPractical();

System.Console.WriteLine("\n * MG core science provider\n ");
TrainingInterface mg= new CoreScienceTrainingServiceProvider();
mg.Evaluate();
mg.Teach();
mg.ConductPractical();

*/

/*
List<TrainingInterface> institutes = new List<TrainingInterface>();

TrainingInterface transflower =new ITTrainingServiceProvider();
TrainingInterface gsm =new ITTrainingServiceProvider();
TrainingInterface autodesk =new AutomobileTrainingServiceProvider();
TrainingInterface mg  =new CoreScienceTrainingServiceProvider();
TrainingInterface hrm =new CoreScienceTrainingServiceProvider();

institutes.Add(transflower);
institutes.Add(gsm);
institutes.Add(autodesk);
institutes.Add(mg);
institutes.Add(hrm);


foreach (TrainingInterface institute in institutes)
{
      institute.Evaluate();
      institute.ConductPractical();
      institute.Teach();
      System.Console.WriteLine("\n");
      System.Console.WriteLine("\t");
   
}
*/

/*
Device robot = new Device();
robot.Draw();
robot.Print();
robot.Read();
robot.Write();

Drawable brush =robot;
Readable scanner= robot;
Writable pen = robot;
//Printable print = robot;

*/

/*
Transaction account= new Transaction();
account.Deposit();
account.Withdraw();
Debitable amount = account;
Creadiable theAmmount=account;

*/
/*
List<Student> allStudent =new List<Student>();
allStudent.Add(new Student(1,"Rahul",12));
allStudent.Add(new Student(2,"Durgesh",14));
allStudent.Add(new Student(3,"Nitin",12));
allStudent.Add(new Student(4,"Ram",13));
allStudent.Add(new Student(5,"Yash",11));
allStudent.Add(new Student(6,"Ganesh",12));
allStudent.Add(new Student(3,"Nitin",12));
 
 
 foreach( Student thestudent in allStudent){
    Console.WriteLine(thestudent);

System.Console.WriteLine("\n");
   
}*/
/*
Student s1 = new Student(1, "Rahul",    12,  75);
Student s2 = new Student(2, "Suraj",    11,  85);
Student s3 = new Student(3, "Vaibhav",  13,  78);
Student s4 = new Student(4, "Yash",     14,  65);
Student s5 = new Student(5, "Abhi",     15,  87);
Student s6 = new Student(6, "Sumit",    16,  66);

List<Student> allStudents1 =new List<Student>();
allStudents1.Add(s1);
allStudents1.Add(s2);
allStudents1.Add(s3);
allStudents1.Add(s4);
allStudents1.Add(s5);
allStudents1.Add(s6);

foreach (Student theStudent in allStudents1)
{
    System.Console.WriteLine(theStudent);
    System.Console.WriteLine("\n");
}


int result= s1.CompareTo(s2);

if(result ==1){
    Console.WriteLine( " s1 percentage is less than s2");
}
else if (result ==-1){
    Console.WriteLine( " S1 percentage is more than s2");
}
else{
    Console.WriteLine( " both having same percentage");
}

foreach ( Student theStudent in allStudents1)
{
    System.Console.WriteLine(theStudent);
}

*/

Player p1 = new Player("Rohit Sharma",8000,260,36,263);
Player p2 = new Player("Sachin Tendulkar",17000,400,45,200);
Player p3 = new Player("Virat Kohli",13000,244,34,183);



List<Player> allPlayers =new List<Player>();
allPlayers.Add(p1);
allPlayers.Add(p2);
allPlayers.Add(p3);


foreach (Player player in allPlayers)
{
    System.Console.WriteLine(player);
    System.Console.WriteLine("\n");
}


int result= p1.CompareTo(p2);

if(result ==1){
    Console.WriteLine( " p1 run is less than p2");
}
else if (result ==-1){
    Console.WriteLine( " p1 run is more than p2");
}
else{
    Console.WriteLine( " both having same run");
}

foreach ( Player player in allPlayers)
{
    System.Console.WriteLine(player );
}
