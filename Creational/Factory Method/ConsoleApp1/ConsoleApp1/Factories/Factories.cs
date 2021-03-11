using ConsoleApp1.Models;
using ConsoleApp1.Models.SubClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Factories
{
   public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();
        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }


    public class MoneyBackFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
    }
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Titanium();
            return product;
        }
    }
}
