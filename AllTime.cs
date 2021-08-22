using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsWinform
{
    class AllTime
    {
        private List<Year> _years = new List<Year>();
        public List<Year> Years
        {
            get
            {
                return _years;
            }
        }

        //private decimal _totalAmount;
        public decimal TotalAmount
        {
            get
            {
                decimal _totalAmount = 0.00M;
                foreach (Year year in Years)
                {
                    _totalAmount += year.TotalAmount;
                }
                return _totalAmount;
            }
        }

        public AllTime() { }

        public AllTime(Year year)
        {
            AddYear(year);
        }

        public void AddYear(Year year)
        {
            Years.Add(year);
        }

        public void PrintTransactions()
        {
            foreach (Year year in Years)
            {
                Console.WriteLine($"YEAR: {year.ThisYear} (TOTAL: {year.TotalAmount})\n");
                year.PrintTransactions();
            }
        }

        public void EmptyAll()
        {
            foreach (Year year in Years)
            {
                year.EmptyAll();
            }
            //_totalAmount = 0.00M;
            Statistics.EmptyAll();
        }

    }
}
