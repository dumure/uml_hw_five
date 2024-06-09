using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_hw_five
{
    internal class BankAccount
    {

        public BankCard AccountCard { get; set; } = null!;
        public float Balance { get; set; }
        public int PIN { get; set; }
    }
}
