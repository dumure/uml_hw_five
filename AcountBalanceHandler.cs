using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_five
{
    internal class AcountBalanceHandler : BaseATMHandler
    {
        public override float Handle(ATM atm, BankAccount bankAccount, int pin, float request_amount)
        {
            if (request_amount > bankAccount.Balance)
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
