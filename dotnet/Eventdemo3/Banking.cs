namespace Bankinglogic
{
 
  public delegate void Accounthandler ();

  public class Account 
  {
   
   public event Accounthandler underBalance,overBalance;

    public double Balance {get; set;}
   public Account(double amount)
   {
     this.Balance=amount;
   }
 
 public void Withdraw(double amount)
 {
    this.Balance-=amount;
    if (Balance<=5000)
 {
     underBalance();
 }
 }

 public void Deposit(double amount)
 {
    this.Balance+=amount;
    if (Balance>=250000)
    {
       overBalance();
    }

 

 }












  }
 



}