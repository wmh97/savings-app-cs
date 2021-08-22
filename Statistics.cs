using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsWinform
{
    class Statistics
    {
        private static decimal _averageTransactionValue = 0;
        public static decimal AverageTransactionValue
        {
            get
            {
                return _averageTransactionValue;
            }
        }

        // updates avg for both in and out - need to separate the
        // two and maintain counters for in/out transactions.
        public static void UpdateAverageTransactionValue(Transaction transaction)
        {
            // prev avg * n-1 to get previous total. Then add new transaction amount and div by n.
            _averageTransactionValue = ((
                _averageTransactionValue * (Transaction.TransactionNumber - 1)) + transaction.Amount
            ) / Transaction.TransactionNumber;
        }

        public static void OnTotalUpdated(Object source, TotalEventArgs e)
        {
            // update statistics.
            UpdateAverageTransactionValue(e.Transaction);

        }

        public static void EmptyAll()
        {
            _averageTransactionValue = 0.00M;
        }

    }
}
