using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingsWinform
{
    public partial class Form1 : Form
    {

        static AllTime Savings = new AllTime();
        static int SelectedMonth = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void transactionInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void storeTransaction_Click(object sender, EventArgs e)
        {

            decimal newTransactionValue = 0.00M;
            try
            {
                newTransactionValue = Convert.ToDecimal(transactionInput.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input! Please enter a valid transaction amount.");
                return;
            }

            int currentYear;
            try
            {
                currentYear = Convert.ToInt32(inputYear.Text);

                foreach (Year year in Form1.Savings.Years)
                {
                    if (currentYear == year.ThisYear)
                    {
                        year.Months[Form1.SelectedMonth].RecordTransaction(newTransactionValue);
                        transactionInput.Clear();
                        allTimeTotalLabel.Text = Convert.ToString((decimal)Form1.Savings.TotalAmount);
                        amountEnteredLabel.Text = Convert.ToString(newTransactionValue);

                        transactionDataGridView1.DataSource = year.Months[Form1.SelectedMonth].Transactions;
                        transactionDataGridView1.Update();


                        return;
                    }
                }

                MessageBox.Show("Inputted amount not stored!");
                return;
            }
            catch
            {
                MessageBox.Show("Selected month or year not found!");
                return;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void addYearMonth_Click(object sender, EventArgs e)
        {
            int newYearValue = 0;
            
            try
            {
                newYearValue = Convert.ToInt32(inputYear.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input! Please enter a valid year.");
                return;
            }

            foreach (Year year in Form1.Savings.Years)
            {
                if (year.ThisYear == newYearValue)
                {
                    MessageBox.Show("This year has already been added.");
                    inputYear.Clear();
                    return;
                }
            }

            Year newYear = new Year(newYearValue);
            Form1.Savings.AddYear(newYear);

            inputYear.Clear();
        }

        private void chooseMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMonth = chooseMonth.SelectedIndex;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newYearLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Savings.PrintTransactions();
        }

        private void allTimeTotalLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshDataGrid1_Click(object sender, EventArgs e)
        {

            transactionDataGridView1.Refresh();
            transactionDataGridView1.Update();
            transactionDataGridView1.DataSource = Form1.Savings.Years;
            transactionDataGridView1.Refresh();
            transactionDataGridView1.Update();
        }
    }
}
