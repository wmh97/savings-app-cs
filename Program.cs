using System;
using System.Collections.Generic;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Year y2021 = new Year(2021);
            y2021.January.RecordTransaction(5.00M);
            y2021.January.RecordTransaction(6.00M);
            y2021.January.RecordTransaction(3.00M);
            y2021.January.RecordTransaction(-4.00M);

            AllTime allTime = new AllTime();
            allTime.AddYear(y2021);
            allTime.PrintTransactions();
        }
    }

    public class AllTime
    {
        private List<Year> _years = new List<Year>();
        public List<Year> Years
        {
            get
            {
                return _years;
            }
        }

        public AllTime(){}

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
                Console.WriteLine($"YEAR: {year.ThisYear}\n");
                year.PrintTransactions();
            }
        }

    }

    public class Year
    {
        public int ThisYear { get; }
        
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
                _months[i] = new Month(i+1, thisYear);
            }
        }

        public void PrintTransactions()
        {
            foreach(Month month in Months)
            {
                month.PrintTransactions();
            }
        }

    }

    public class Month
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
            _transactions.Add(new Transaction(change));
        }

        public void PrintTransactions()
        {
            Console.WriteLine($"Date: {CalendarMonth}/{Year}");
            foreach (Transaction transaction in Transactions)
            {
                Console.WriteLine(transaction.Amount);
            }
            Console.WriteLine($"TOTAL: {TotalAmount}\n");
        }        
    }

    public class Transaction
    {
        public decimal Amount { get; } = 0.00M;
        public string Category { get; } = "";

        public Transaction(decimal amount)
        {
            Amount = amount;
        }
    }
    
}
