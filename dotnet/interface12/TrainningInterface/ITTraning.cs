namespace Training
{
public class ITTrainingServiceProvider:TrainingInterface
  {

 public void Evaluate()
     {
        System.Console.WriteLine("Candidate have been evaluated against computer Science");
     }
public void Teach()
    {
        System.Console.WriteLine("Candidate have been taught Computer Science Subject");
    }
public void ConductPractical()
    {
        System.Console.WriteLine("conducting java, .net, mysql, react practical");
    }

   }

}
