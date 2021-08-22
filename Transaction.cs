using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsWinform
{
    enum TransactionCategory
    {
        NECESSITIES,
        LEISURE,
        SALARY,
        FINANCIAL
    }

    class Transaction
    {
        public decimal Amount { get; } = 0.00M;
        public TransactionCategory Category { get; }
        public bool InOut; // 0 = out, 1 = in

        private static int _transactionNumber = 0;
        public static int TransactionNumber
        {
            get
            {
                return _transactionNumber;
            }
        }

        public Transaction(decimal amount)
        {
            Amount = amount;

            if (Amount < 0)
            {
                InOut = false;
            }
            else
            {
                InOut = true;
            }

            _transactionNumber++;
        }

        public Transaction(decimal amount, TransactionCategory category)
        {
            Amount = amount;
            Category = category;

            if (Amount < 0)
            {
                InOut = false;
            }
            else
            {
                InOut = true;
            }

            _transactionNumber++;
        }

    }
}
