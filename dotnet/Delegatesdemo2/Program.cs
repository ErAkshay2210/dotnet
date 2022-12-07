using Delegates;

double amount =5000;
double money =2500;



TaxHandler taxHandler= new TaxHandler(Controller.PayIncomeTax);
TaxHandler tds= new TaxHandler(Controller.PayTDS);
Dispatcher dispatcher=new Dispatcher(Controller.SendEmail);
Dispatcher sms =new Dispatcher(Controller.Sms);


taxHandler.Invoke(amount);
tds.Invoke(money);

sms.Invoke("hii","9921337459");