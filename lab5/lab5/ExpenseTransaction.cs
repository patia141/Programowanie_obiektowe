using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.bank
{
    public class ExpenseTransaction: Transaction
    {
        public override void ProccessTransaction()
        {
            Account.Expense += Amount;
        }
    }
}
