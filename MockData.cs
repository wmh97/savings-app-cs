using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsWinform
{
    class MockData
    {
        public static void GenerateTransactions(AllTime allTime)
        {
            Random rand = new Random();

            // first generate a number of years (ie between 1 and 3)
            int numberOfYears = rand.Next(1, 4);
            int thisYear = 2015;
            for (int i = 0; i < numberOfYears; i++)
            {
                Year newYear = new Year(thisYear);
                allTime.AddYear(newYear);

                // Then, for each month in each year generate a number of transactions (ie between 30 and 60)
                foreach (Month month in newYear.Months)
                {
                    int numberOfTransactions = rand.Next(5, 61);

                    // For each of those transactions generate a transaction amount (ie between 1 and 50)
                    for (int j = 0; j < numberOfTransactions; j++)
                    {
                        decimal transactionAmount = (decimal)(rand.Next(1, 51) + rand.NextDouble());
                        Transaction newTransaction = new Transaction(transactionAmount);
                        month.RecordTransaction(newTransaction.Amount);
                    }

                }

                // increment the year to move onto the new year.
                thisYear++;
            }
        }
    }
}
