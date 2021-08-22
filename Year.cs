using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsWinform
{
    class Year
    {
        public int ThisYear { get; }

        private decimal _totalAmount = 0.0M;
        public decimal TotalAmount
        {
            get
            {
                return _totalAmount;
            }
        }


        private Month[] _months = new Month[12];
        public Month[] Months
        {
            get
            {
                return _months;
            }
        }
        public Month January { get { return Months[0]; } }
        public Month February { get { return Months[1]; } }
        public Month March { get { return Months[2]; } }
        public Month April { get { return Months[3]; } }
        public Month May { get { return Months[4]; } }
        public Month June { get { return Months[5]; } }
        public Month July { get { return Months[6]; } }
        public Month August { get { return Months[7]; } }
        public Month September { get { return Months[8]; } }
        public Month October { get { return Months[9]; } }
        public Month November { get { return Months[10]; } }
        public Month December { get { return Months[11]; } }

        public Year(int thisYear)
        {
            ThisYear = thisYear;

            for (int i = 0; i < 12; i++)
            {
                _months[i] = new Month(i + 1, thisYear);

                // subscribing the year to the events that month publishes
                // each time the total is updated.
                _months[i].TotalUpdated += OnTotalUpdated;
                _months[i].TotalUpdated += Statistics.OnTotalUpdated;
            }
        }

        public void OnTotalUpdated(Object source, TotalEventArgs e)
        {
            // Console.WriteLine($"UPDATING YEAR TOTAL: {e.Change}");
            _totalAmount += e.Transaction.Amount;
        }

        public void PrintTransactions()
        {
            foreach (Month month in Months)
            {
                month.PrintTransactions();
            }
        }

        public void EmptyAll()
        {
            foreach (Month month in Months)
            {
                month.Transactions.Clear();
                month.EmptyAll();
            }
            _totalAmount = 0.00M;
        }

    }
}
