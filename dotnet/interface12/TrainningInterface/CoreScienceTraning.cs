namespace Training
{
public class CoreScienceTrainingServiceProvider:TrainingInterface
  {

 public void Evaluate()
     {
        System.Console.WriteLine("Candidate have been evaluated against physics,Chemistry,Biology");
     }
public void Teach()
    {
        System.Console.WriteLine("Candidate have been taught phyics ,chemistry,Biology Subjects");
    }
public void ConductPractical()
    {
        System.Console.WriteLine("conducting physics,Chemistry,Biology practical");
    }

   }

}
