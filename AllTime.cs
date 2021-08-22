using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        private List<int> _yearNumbers = new List<int>();
        public List<int> YearNumbers
        {
            get
            {
                return _yearNumbers;
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
            YearNumbers.Add(year.ThisYear);
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

        public static void SaveRecords(AllTime allTime)
        {
            string fileName = "savingsRecords.json";
            var options = new JsonSerializerOptions { IncludeFields = true };
            string jsonString = JsonSerializer.Serialize(allTime, options);
            File.WriteAllText(fileName, jsonString);
        }

        public static AllTime LoadRecords()
        {
            string fileName = "savingsRecords.json";
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<AllTime>(jsonString);
        }
    }
}
