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
        static int SelectedYear = 0;

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


            SelectedYear = (int)chooseYear.SelectedItem;
            foreach (Year year in Form1.Savings.Years)
            {
                if (SelectedYear == year.ThisYear)
                {
                    year.Months[Form1.SelectedMonth].RecordTransaction(newTransactionValue);
                    transactionInput.Clear();
                        
                    allTimeTotalLabel.Text = Convert.ToString(Math.Ceiling((decimal)Form1.Savings.TotalAmount * 100) / 100);
                    amountEnteredLabel.Text = Convert.ToString(newTransactionValue);

                    averageTransactionAmountLabel.Text = Convert.ToString(Math.Ceiling(Statistics.AverageTransactionValue * 100) / 100);

                    transactionDataGridView1.DataSource = null;
                    transactionDataGridView1.DataSource = year.Months[Form1.SelectedMonth].Transactions;


                    return;
                }
            }

            MessageBox.Show("Inputted amount not stored!");
            return;


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

            transactionDataGridView1.DataSource = null;
            transactionDataGridView1.DataSource = Form1.Savings.Years;

            chooseYear.DataSource = null;
            chooseYear.DataSource = Form1.Savings.YearNumbers;

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

        private void allTimeTotalLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refreshDataGrid1_Click(object sender, EventArgs e)
        {

            transactionDataGridView1.DataSource = null;
            transactionDataGridView1.DataSource = Form1.Savings.Years;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedYear = (int)chooseYear.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (Year year in Form1.Savings.Years)
            {
                if (year.ThisYear == Form1.SelectedYear)
                {
                    transactionDataGridView1.DataSource = null;
                    transactionDataGridView1.DataSource = year.Months[Form1.SelectedMonth].Transactions;
                    return;
                }
            }

            MessageBox.Show("Could not get month view!");
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mockTransactionDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.Savings.EmptyAll();
            MockData.GenerateTransactions(Form1.Savings);

            // put years and data into combo boxes and data grid.
            transactionDataGridView1.DataSource = null;
            transactionDataGridView1.DataSource = Form1.Savings.Years;

            chooseYear.DataSource = null;
            chooseYear.DataSource = Form1.Savings.YearNumbers;
        }

        private void saveRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AllTime.SaveRecords(Form1.Savings);
                MessageBox.Show("Saved successfully.");
            }
            catch
            {
                MessageBox.Show("Could not save transaction records!");
            }
        }

        private void loadRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Load feature not working yet.");

            /*
                Load Records Currently Not Working! 
            */

            /*Form1.Savings.EmptyAll();
            try
            {
                Form1.Savings = AllTime.LoadRecords();
                MessageBox.Show("Loaded successfully.");
            }
            catch
            {
                MessageBox.Show("Could not load transaction records!");
            }

            transactionDataGridView1.DataSource = null;
            transactionDataGridView1.DataSource = Form1.Savings.Years;

            chooseYear.DataSource = null;
            chooseYear.DataSource = Form1.Savings.YearNumbers;*/

        }
    }
}
