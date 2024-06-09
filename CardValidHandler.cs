using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_five
{
    internal class CardValidHandler : BaseATMHandler
    {
        public override float Handle(ATM atm, BankAccount bankAccount, int pin, float request_amount)
        {
            if (!bankAccount.AccountCard.IsCardValid)
            {
                return 0;
            }
            else
            {
                return nextHandler.Handle(atm, bankAccount, pin, request_amount);
            }
        }
    }
}
