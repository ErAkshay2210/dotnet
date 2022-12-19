namespace School

{


    public class Student : IComparable
    {

         public int rollNo;

         public string name;

         public int age;

         public int percentage;


    

   public Student(int rollno ,string name ,int age, int percentage)
   {
      this.rollNo=rollno;
      this.name=name;
      this.age= age;
      this.percentage=percentage;
   }

        public int CompareTo(object? obj)
        {
            Student anotherStudent = (Student) obj;
            if (this.percentage < anotherStudent.percentage)
            {
            return 1;
            }
             else if (this.percentage > anotherStudent.percentage){
            return -1;
        }
        else
        return 0;
            }

        public override string ToString()
   {
      string str = string.Format ("{0},{1},{2}", this.name,this.age,this.rollNo, this.percentage);
      return str;
      System.Console.WriteLine("\n");
   }
   
}

}
