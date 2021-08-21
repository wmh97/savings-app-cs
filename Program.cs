using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

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

            System.Console.WriteLine("All Time Total: " + allTime.TotalAmount + '\n');
            allTime.PrintTransactions();

            Program.saveRecords(allTime);

        }

        static void saveRecords(AllTime allTime)
        {
            string fileName = "savingsRecords.json"; 
            string jsonString = JsonSerializer.Serialize(allTime);
            File.WriteAllText(fileName, jsonString);
        }

        static AllTime loadRecords()
        { 
            string fileName = "savingsRecords.json";
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<AllTime>(jsonString);
        }
    }

    public class Statistics
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
            _averageTransactionValue = ( (
                _averageTransactionValue * (Transaction.TransactionNumber-1)) + transaction.Amount 
            ) / Transaction.TransactionNumber;            

            System.Console.WriteLine(
                $"AVG: at no. {Transaction.TransactionNumber}"
            );
            System.Console.WriteLine(AverageTransactionValue);
        }

        public static void OnTotalUpdated(Object source, TotalEventArgs e)
        {
            // update statistics.
            UpdateAverageTransactionValue(e.Transaction);

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

        private decimal _totalAmount;
        public decimal TotalAmount
        {
            get
            {
                foreach (Year year in Years)
                {
                    _totalAmount += year.TotalAmount;
                }
                return _totalAmount;
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
                Console.WriteLine($"YEAR: {year.ThisYear} (TOTAL: {year.TotalAmount})\n");
                year.PrintTransactions();
            }
        }

    }

    public class Year
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
        public Month January   { get { return Months[0];  } }
        public Month February  { get { return Months[1];  } }
        public Month March     { get { return Months[2];  } }
        public Month April     { get { return Months[3];  } }
        public Month May       { get { return Months[4];  } }
        public Month June      { get { return Months[5];  } }
        public Month July      { get { return Months[6];  } }
        public Month August    { get { return Months[7];  } }
        public Month September { get { return Months[8];  } }
        public Month October   { get { return Months[9];  } }
        public Month November  { get { return Months[10]; } }
        public Month December  { get { return Months[11]; } }

        public Year(int thisYear)
        {
            ThisYear = thisYear;
            
            for (int i = 0; i < 12; i++)
            {
                _months[i] = new Month(i+1, thisYear);

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
                TotalUpdated(this, new TotalEventArgs(){ Transaction = newTransaction });
            }
        }

      

        public void PrintTransactions()
        {
            Console.WriteLine($"Date: {CalendarMonth}/{Year}");
            foreach (Transaction transaction in Transactions)
            {
                if(transaction.Amount > 0)
                {
                    Console.WriteLine($"IN:  {transaction.Amount}");    
                }
                else if (transaction.Amount < 0)
                {
                    Console.WriteLine($"OUT: {transaction.Amount*-1}");
                }
            }
            Console.WriteLine($"TOTAL: {TotalAmount}\n");
        }        
    }

    public class TotalEventArgs : EventArgs
    {
        public Transaction Transaction { get; set; }
    }      

    public enum TransactionCategory
    {
        NECESSITIES,
        LEISURE,
        SALARY,
        FINANCIAL
    }

    public class Transaction
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
