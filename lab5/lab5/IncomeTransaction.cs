using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.bank
{
    public class IncomeTransaction: Transaction
    {
        public override void ProccessTransaction()
        {
            Account.Income += Amount;
        }
    }
}
