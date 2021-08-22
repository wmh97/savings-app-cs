
namespace SavingsWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.yearSelectionLabel = new System.Windows.Forms.Label();
            this.chooseYear = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.addYearMonth = new System.Windows.Forms.Button();
            this.amountEnteredLabel = new System.Windows.Forms.Label();
            this.plusEquals = new System.Windows.Forms.Label();
            this.chooseMonth = new System.Windows.Forms.ComboBox();
            this.newYearLabel = new System.Windows.Forms.Label();
            this.allTimeTotalLabel = new System.Windows.Forms.Label();
            this.transactionAmountLabel = new System.Windows.Forms.Label();
            this.inputYear = new System.Windows.Forms.TextBox();
            this.storeTransaction = new System.Windows.Forms.Button();
            this.transactionInput = new System.Windows.Forms.TextBox();
            this.averageTransactionAmountLabel = new System.Windows.Forms.Label();
            this.averageTransactionLabel = new System.Windows.Forms.Label();
            this.refreshDataGrid1 = new System.Windows.Forms.Button();
            this.transactionDataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.monthViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.yearSelectionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.chooseYear);
            this.splitContainer1.Panel1.Controls.Add(this.monthLabel);
            this.splitContainer1.Panel1.Controls.Add(this.addYearMonth);
            this.splitContainer1.Panel1.Controls.Add(this.amountEnteredLabel);
            this.splitContainer1.Panel1.Controls.Add(this.plusEquals);
            this.splitContainer1.Panel1.Controls.Add(this.chooseMonth);
            this.splitContainer1.Panel1.Controls.Add(this.newYearLabel);
            this.splitContainer1.Panel1.Controls.Add(this.allTimeTotalLabel);
            this.splitContainer1.Panel1.Controls.Add(this.transactionAmountLabel);
            this.splitContainer1.Panel1.Controls.Add(this.inputYear);
            this.splitContainer1.Panel1.Controls.Add(this.storeTransaction);
            this.splitContainer1.Panel1.Controls.Add(this.transactionInput);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.splitContainer1.Panel2.Controls.Add(this.monthViewButton);
            this.splitContainer1.Panel2.Controls.Add(this.averageTransactionAmountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.averageTransactionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.refreshDataGrid1);
            this.splitContainer1.Panel2.Controls.Add(this.transactionDataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(989, 446);
            this.splitContainer1.SplitterDistance = 480;
            this.splitContainer1.TabIndex = 0;
            // 
            // yearSelectionLabel
            // 
            this.yearSelectionLabel.AutoSize = true;
            this.yearSelectionLabel.Location = new System.Drawing.Point(7, 385);
            this.yearSelectionLabel.Name = "yearSelectionLabel";
            this.yearSelectionLabel.Size = new System.Drawing.Size(40, 20);
            this.yearSelectionLabel.TabIndex = 9;
            this.yearSelectionLabel.Text = "Year:";
            // 
            // chooseYear
            // 
            this.chooseYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseYear.FormattingEnabled = true;
            this.chooseYear.Location = new System.Drawing.Point(7, 408);
            this.chooseYear.Name = "chooseYear";
            this.chooseYear.Size = new System.Drawing.Size(92, 28);
            this.chooseYear.TabIndex = 8;
            this.chooseYear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(105, 385);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(55, 20);
            this.monthLabel.TabIndex = 7;
            this.monthLabel.Text = "Month:";
            // 
            // addYearMonth
            // 
            this.addYearMonth.Location = new System.Drawing.Point(138, 341);
            this.addYearMonth.Name = "addYearMonth";
            this.addYearMonth.Size = new System.Drawing.Size(94, 29);
            this.addYearMonth.TabIndex = 6;
            this.addYearMonth.Text = "Add";
            this.addYearMonth.UseVisualStyleBackColor = true;
            this.addYearMonth.Click += new System.EventHandler(this.addYearMonth_Click);
            // 
            // amountEnteredLabel
            // 
            this.amountEnteredLabel.AutoSize = true;
            this.amountEnteredLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountEnteredLabel.Location = new System.Drawing.Point(101, 78);
            this.amountEnteredLabel.Name = "amountEnteredLabel";
            this.amountEnteredLabel.Size = new System.Drawing.Size(312, 46);
            this.amountEnteredLabel.TabIndex = 1;
            this.amountEnteredLabel.Text = "<Amount Entered>";
            // 
            // plusEquals
            // 
            this.plusEquals.AutoSize = true;
            this.plusEquals.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusEquals.Location = new System.Drawing.Point(29, 72);
            this.plusEquals.Name = "plusEquals";
            this.plusEquals.Size = new System.Drawing.Size(66, 46);
            this.plusEquals.TabIndex = 2;
            this.plusEquals.Text = "+=";
            // 
            // chooseMonth
            // 
            this.chooseMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseMonth.FormattingEnabled = true;
            this.chooseMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.chooseMonth.Location = new System.Drawing.Point(105, 408);
            this.chooseMonth.Name = "chooseMonth";
            this.chooseMonth.Size = new System.Drawing.Size(130, 28);
            this.chooseMonth.TabIndex = 5;
            this.chooseMonth.SelectedIndexChanged += new System.EventHandler(this.chooseMonth_SelectedIndexChanged);
            // 
            // newYearLabel
            // 
            this.newYearLabel.AutoSize = true;
            this.newYearLabel.Location = new System.Drawing.Point(7, 320);
            this.newYearLabel.Name = "newYearLabel";
            this.newYearLabel.Size = new System.Drawing.Size(72, 20);
            this.newYearLabel.TabIndex = 4;
            this.newYearLabel.Text = "Add Year:";
            this.newYearLabel.Click += new System.EventHandler(this.newYearLabel_Click);
            // 
            // allTimeTotalLabel
            // 
            this.allTimeTotalLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allTimeTotalLabel.Location = new System.Drawing.Point(16, 9);
            this.allTimeTotalLabel.Name = "allTimeTotalLabel";
            this.allTimeTotalLabel.Size = new System.Drawing.Size(322, 63);
            this.allTimeTotalLabel.TabIndex = 0;
            this.allTimeTotalLabel.Text = "<Total Amount>";
            this.allTimeTotalLabel.Click += new System.EventHandler(this.allTimeTotalLabel_Click);
            // 
            // transactionAmountLabel
            // 
            this.transactionAmountLabel.AutoSize = true;
            this.transactionAmountLabel.Location = new System.Drawing.Point(239, 386);
            this.transactionAmountLabel.Name = "transactionAmountLabel";
            this.transactionAmountLabel.Size = new System.Drawing.Size(144, 20);
            this.transactionAmountLabel.TabIndex = 3;
            this.transactionAmountLabel.Text = "Transaction Amount:";
            this.transactionAmountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputYear
            // 
            this.inputYear.Location = new System.Drawing.Point(7, 343);
            this.inputYear.Name = "inputYear";
            this.inputYear.Size = new System.Drawing.Size(125, 27);
            this.inputYear.TabIndex = 2;
            this.inputYear.TextChanged += new System.EventHandler(this.inputYear_TextChanged);
            // 
            // storeTransaction
            // 
            this.storeTransaction.Location = new System.Drawing.Point(406, 409);
            this.storeTransaction.Name = "storeTransaction";
            this.storeTransaction.Size = new System.Drawing.Size(65, 29);
            this.storeTransaction.TabIndex = 1;
            this.storeTransaction.Text = "Enter";
            this.storeTransaction.UseVisualStyleBackColor = true;
            this.storeTransaction.Click += new System.EventHandler(this.storeTransaction_Click);
            // 
            // transactionInput
            // 
            this.transactionInput.Location = new System.Drawing.Point(243, 409);
            this.transactionInput.Name = "transactionInput";
            this.transactionInput.Size = new System.Drawing.Size(156, 27);
            this.transactionInput.TabIndex = 0;
            this.transactionInput.TextChanged += new System.EventHandler(this.transactionInput_TextChanged);
            // 
            // averageTransactionAmountLabel
            // 
            this.averageTransactionAmountLabel.AutoSize = true;
            this.averageTransactionAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.averageTransactionAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.averageTransactionAmountLabel.Location = new System.Drawing.Point(269, 9);
            this.averageTransactionAmountLabel.Name = "averageTransactionAmountLabel";
            this.averageTransactionAmountLabel.Size = new System.Drawing.Size(187, 46);
            this.averageTransactionAmountLabel.TabIndex = 6;
            this.averageTransactionAmountLabel.Text = "<Amount>";
            this.averageTransactionAmountLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // averageTransactionLabel
            // 
            this.averageTransactionLabel.AutoSize = true;
            this.averageTransactionLabel.BackColor = System.Drawing.Color.Transparent;
            this.averageTransactionLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.averageTransactionLabel.Location = new System.Drawing.Point(3, 9);
            this.averageTransactionLabel.Name = "averageTransactionLabel";
            this.averageTransactionLabel.Size = new System.Drawing.Size(260, 37);
            this.averageTransactionLabel.TabIndex = 5;
            this.averageTransactionLabel.Text = "Average Transaction:";
            // 
            // refreshDataGrid1
            // 
            this.refreshDataGrid1.Location = new System.Drawing.Point(394, 96);
            this.refreshDataGrid1.Name = "refreshDataGrid1";
            this.refreshDataGrid1.Size = new System.Drawing.Size(99, 29);
            this.refreshDataGrid1.TabIndex = 4;
            this.refreshDataGrid1.Text = "Year View";
            this.refreshDataGrid1.UseVisualStyleBackColor = true;
            this.refreshDataGrid1.Click += new System.EventHandler(this.refreshDataGrid1_Click);
            // 
            // transactionDataGridView1
            // 
            this.transactionDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView1.Location = new System.Drawing.Point(16, 137);
            this.transactionDataGridView1.Name = "transactionDataGridView1";
            this.transactionDataGridView1.RowHeadersWidth = 51;
            this.transactionDataGridView1.RowTemplate.Height = 29;
            this.transactionDataGridView1.Size = new System.Drawing.Size(477, 300);
            this.transactionDataGridView1.TabIndex = 3;
            this.transactionDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // monthViewButton
            // 
            this.monthViewButton.Location = new System.Drawing.Point(282, 96);
            this.monthViewButton.Name = "monthViewButton";
            this.monthViewButton.Size = new System.Drawing.Size(106, 29);
            this.monthViewButton.TabIndex = 7;
            this.monthViewButton.Text = "Month View";
            this.monthViewButton.UseVisualStyleBackColor = true;
            this.monthViewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 446);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button storeTransaction;
        private System.Windows.Forms.TextBox transactionInput;
        private System.Windows.Forms.Label transactionAmountLabel;
        private System.Windows.Forms.TextBox inputYear;
        private System.Windows.Forms.Button addYearMonth;
        private System.Windows.Forms.Label newYearLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label allTimeTotalLabel;
        private System.Windows.Forms.Label plusEquals;
        private System.Windows.Forms.Label amountEnteredLabel;
        private System.Windows.Forms.DataGridView transactionDataGridView1;
        private System.Windows.Forms.Button refreshDataGrid1;
        private System.Windows.Forms.Label averageTransactionAmountLabel;
        private System.Windows.Forms.Label averageTransactionLabel;
        protected System.Windows.Forms.ComboBox chooseMonth;
        private System.Windows.Forms.ComboBox chooseYear;
        private System.Windows.Forms.Label yearSelectionLabel;
        private System.Windows.Forms.Button monthViewButton;
    }
}

