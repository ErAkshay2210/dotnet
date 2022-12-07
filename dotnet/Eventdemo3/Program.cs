using Bankinglogic;
using GovtLib;
using Notification;


Account acct =new Account(50000);
Receiver rs=new Receiver();
TaxManager tm=new TaxManager();

acct.overBalance +=tm.DeductIncomeTax;
acct.overBalance +=tm.DeductServiceTax;
acct.overBalance +=tm.DeductTds;

acct.underBalance +=rs.BlockAccount;
acct.underBalance +=rs.SendEmail;
acct.underBalance +=rs.SendSms;

/*
System.Console.WriteLine("Enter Amount to Withdraw");
double amount =double.Parse(Console.ReadLine());
acct.Withdraw(amount);
System.Console.WriteLine(acct.Balance);
*/

System.Console.WriteLine("Enter Deposit Amount ");
double amount =double.Parse(Console.ReadLine());
acct.Deposit(amount);
System.Console.WriteLine(acct.Balance);


