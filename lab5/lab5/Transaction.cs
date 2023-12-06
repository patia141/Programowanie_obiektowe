using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.bank
{
    public abstract class Transaction
    {
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public abstract void ProccessTransaction();
    }
}
