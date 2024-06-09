using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_five
{
    internal abstract class BaseATMHandler
    {
        protected BaseATMHandler nextHandler = null!;
        public virtual BaseATMHandler SetNext(BaseATMHandler nextHandler)
        {
            this.nextHandler = nextHandler;
            return this;
        }
        public abstract float Handle(ATM atm, BankAccount bankAccount, int pin, float request_amount);
    }
}
