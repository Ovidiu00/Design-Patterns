using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design.Models
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
