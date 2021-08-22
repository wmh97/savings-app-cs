using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsWinform
{
    class Month
    {

        public int CalendarMonth { get; }
        public int Year { get; }

        private List<Transaction> _transactions = new List<Transaction>();
        public List<Transaction> Transactions
        {
            get
            {
                return _transactions;
            }
        }

        private decimal _totalAmount = 0.0M;
        public decimal TotalAmount
        {
            get
            {
                return _totalAmount;
            }
        }

        public Month(int month, int year)
        {
            CalendarMonth = month;
            Year = year;
            _totalAmount = 0.00M;

        }

        public void RecordTransaction(decimal change)
        {
            _totalAmount += change;

            Transaction newTransaction = new Transaction(change);
            _transactions.Add(newTransaction);
            OnTotalUpdated(newTransaction); // trigger event to update year total.
        }

        public void RecordTransaction(decimal change, TransactionCategory category)
        {
            _totalAmount += change;
            Transaction newTransaction = new Transaction(change, category);
            _transactions.Add(newTransaction);
            OnTotalUpdated(newTransaction);
        }

        // Event - updating the total of a month updates the total of the year by
        // the same amount.
        public event EventHandler<TotalEventArgs> TotalUpdated;
        protected virtual void OnTotalUpdated(Transaction newTransaction)
        {
            if (TotalUpdated != null)
            {
                TotalUpdated(this, new TotalEventArgs() { Transaction = newTransaction });
            }
        }

        public void PrintTransactions()
        {
            Console.WriteLine($"Date: {CalendarMonth}/{Year}");
            foreach (Transaction transaction in Transactions)
            {
                if (transaction.Amount > 0)
                {
                    Console.WriteLine($"IN:  {transaction.Amount}");
                }
                else if (transaction.Amount < 0)
                {
                    Console.WriteLine($"OUT: {transaction.Amount * -1}");
                }
            }
            Console.WriteLine($"TOTAL: {TotalAmount}\n");
        }

        public void EmptyAll()
        {
            _totalAmount = 0.00M;
        }
    }

    class TotalEventArgs : EventArgs
    {
        public Transaction Transaction { get; set; }
    }

}
