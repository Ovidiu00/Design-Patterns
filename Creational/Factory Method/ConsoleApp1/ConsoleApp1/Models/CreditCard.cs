using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
