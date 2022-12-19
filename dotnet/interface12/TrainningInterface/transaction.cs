namespace Account
{

    public class Transaction : Debitable, Creadiable

    {

  
    public void Deposit(){
        System.Console.WriteLine( "Amount is added into Shopper account ");
        System.Console.WriteLine("updated balance");
    }

    public void Withdraw()
    {
        System.Console.WriteLine( " amount is withdrawn from consumers shoppers account");

    }
}
}