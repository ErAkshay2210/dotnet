using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentProcesing
{
    public class FuturePaymentIntentModel
    {
        public string Id { get; set; }
        public string IntentSecret { get; set; }
        public CustomerModel Customer { get; set; }
    }

    public class CustomerModel
    {
        public string Id { get; set; }
        public string SystemId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<PaymentMethodModel> PaymentMethods { get; set; }

        public CustomerModel(string id)
        {
            Id = id;
        }
    }

    public enum PaymentModelInclude
    {
        PaymentMethods
    }

    public class PlanModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<PlanPriceModel> Prices { get; set; }
    }

    public class PlanPriceModel
    {
        public string Id { get; set; }
        public long UnitAmount { get; set; }
        public PriceInterval Interval { get; set; }
        public Currency Currency { get; set; }
    }


    public class PaymentMethodModel
    {
        public string Id { get; set; }
        public PaymentMethodType Type { get; set; }
        public PaymentMethodCardModel Card { get; set; }

        public PaymentMethodModel(string id)
        {
            Id = id;
        }
    }

    public class PaymentMethodCardModel
    {
        public string Brand { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public long ExpMonth { get; set; }
        public long ExpYear { get; set; }
        public string Fingerprint { get; set; }
        public string Funding { get; set; }
        public string Iin { get; set; }
        public string Issuer { get; set; }
        public string Last4 { get; set; }
    }

    public class ChargeModel
    {
        public string Id { get; }
        public string Status { get; set; }

        public ChargeModel(string id)
        {
            Id = id;
        }
    }

    public enum PriceInterval
    {
        Monthly,
        Yearly
    }

    public enum Currency
    {
        Eur,
        USD
    }

    public enum PaymentMethodType
    {
        Card
    }


    public enum PriceRecurringOption
    {
        month,
        year
    }
    
}
public class CreateSubscriptionRequest
    {
       
        public string PaymentMethodId { get; set; }

     
        public string CustomerId { get; set; }

     
        public string PriceId { get; set; }
    }



 public class ChargeViewModel
    {
        public string StripeToken { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string CardNumber { get; set; }
        public string Cvc { get; set; }
    }
   

   public class Price{
        public  int Product {get;set;}  
        public double UnitAmount{get;set;}
        public string Currency {get;set;}
       //public  PriceRecurringOption  Recurring{get;set;} 
   }


    public class CreateCustomerModel
    {
        public string SystemId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    