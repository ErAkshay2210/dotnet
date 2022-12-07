using System;


namespace Delegates
{

    public delegate void TaxHandler(double amount);

    public delegate void Dispatcher(string name, string body);
public class Controller
{

public static void PayIncomeTax(double amount)
{
    Console.WriteLine(" income tax has been automatically deducted from your account :{0}" , amount);
}

public static void PayTDS(double money)
{
    Console.WriteLine(  "TDS has been automatically deducted from your bank account :{0}" , money );
}

public static void SendEmail(string mail, string message)
{
    Console.WriteLine( "Email has been send to respective person ", mail,message );
}

public static void Sms(string message , string contactNumber)
{
 Console.WriteLine( "msg has been send:{0},{1} ",message , contactNumber);
}







}

}