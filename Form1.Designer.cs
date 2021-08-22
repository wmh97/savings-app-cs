
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
            this.monthLabel = new System.Windows.Forms.Label();
            this.addYearMonth = new System.Windows.Forms.Button();
            this.chooseMonth = new System.Windows.Forms.ComboBox();
            this.newYearLabel = new System.Windows.Forms.Label();
            this.transactionAmountLabel = new System.Windows.Forms.Label();
            this.inputYear = new System.Windows.Forms.TextBox();
            this.storeTransaction = new System.Windows.Forms.Button();
            this.transactionInput = new System.Windows.Forms.TextBox();
            this.plusEquals = new System.Windows.Forms.Label();
            this.amountEnteredLabel = new System.Windows.Forms.Label();
            this.allTimeTotalLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.monthLabel);
            this.splitContainer1.Panel1.Controls.Add(this.addYearMonth);
            this.splitContainer1.Panel1.Controls.Add(this.chooseMonth);
            this.splitContainer1.Panel1.Controls.Add(this.newYearLabel);
            this.splitContainer1.Panel1.Controls.Add(this.transactionAmountLabel);
            this.splitContainer1.Panel1.Controls.Add(this.inputYear);
            this.splitContainer1.Panel1.Controls.Add(this.storeTransaction);
            this.splitContainer1.Panel1.Controls.Add(this.transactionInput);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.plusEquals);
            this.splitContainer1.Panel2.Controls.Add(this.amountEnteredLabel);
            this.splitContainer1.Panel2.Controls.Add(this.allTimeTotalLabel);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 389;
            this.splitContainer1.TabIndex = 0;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(11, 386);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(55, 20);
            this.monthLabel.TabIndex = 7;
            this.monthLabel.Text = "Month:";
            // 
            // addYearMonth
            // 
            this.addYearMonth.Location = new System.Drawing.Point(147, 341);
            this.addYearMonth.Name = "addYearMonth";
            this.addYearMonth.Size = new System.Drawing.Size(94, 29);
            this.addYearMonth.TabIndex = 6;
            this.addYearMonth.Text = "Add";
            this.addYearMonth.UseVisualStyleBackColor = true;
            this.addYearMonth.Click += new System.EventHandler(this.addYearMonth_Click);
            // 
            // chooseMonth
            // 
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
            this.chooseMonth.Location = new System.Drawing.Point(11, 409);
            this.chooseMonth.Name = "chooseMonth";
            this.chooseMonth.Size = new System.Drawing.Size(130, 28);
            this.chooseMonth.TabIndex = 5;
            this.chooseMonth.SelectedIndexChanged += new System.EventHandler(this.chooseMonth_SelectedIndexChanged);
            // 
            // newYearLabel
            // 
            this.newYearLabel.AutoSize = true;
            this.newYearLabel.Location = new System.Drawing.Point(12, 320);
            this.newYearLabel.Name = "newYearLabel";
            this.newYearLabel.Size = new System.Drawing.Size(129, 20);
            this.newYearLabel.TabIndex = 4;
            this.newYearLabel.Text = "Add Another Year:";
            this.newYearLabel.Click += new System.EventHandler(this.newYearLabel_Click);
            // 
            // transactionAmountLabel
            // 
            this.transactionAmountLabel.AutoSize = true;
            this.transactionAmountLabel.Location = new System.Drawing.Point(150, 387);
            this.transactionAmountLabel.Name = "transactionAmountLabel";
            this.transactionAmountLabel.Size = new System.Drawing.Size(144, 20);
            this.transactionAmountLabel.TabIndex = 3;
            this.transactionAmountLabel.Text = "Transaction Amount:";
            this.transactionAmountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputYear
            // 
            this.inputYear.Location = new System.Drawing.Point(16, 343);
            this.inputYear.Name = "inputYear";
            this.inputYear.Size = new System.Drawing.Size(125, 27);
            this.inputYear.TabIndex = 2;
            this.inputYear.TextChanged += new System.EventHandler(this.inputYear_TextChanged);
            // 
            // storeTransaction
            // 
            this.storeTransaction.Location = new System.Drawing.Point(312, 409);
            this.storeTransaction.Name = "storeTransaction";
            this.storeTransaction.Size = new System.Drawing.Size(65, 29);
            this.storeTransaction.TabIndex = 1;
            this.storeTransaction.Text = "Enter";
            this.storeTransaction.UseVisualStyleBackColor = true;
            this.storeTransaction.Click += new System.EventHandler(this.storeTransaction_Click);
            // 
            // transactionInput
            // 
            this.transactionInput.Location = new System.Drawing.Point(150, 410);
            this.transactionInput.Name = "transactionInput";
            this.transactionInput.Size = new System.Drawing.Size(156, 27);
            this.transactionInput.TabIndex = 0;
            this.transactionInput.TextChanged += new System.EventHandler(this.transactionInput_TextChanged);
            // 
            // plusEquals
            // 
            this.plusEquals.AutoSize = true;
            this.plusEquals.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusEquals.Location = new System.Drawing.Point(16, 76);
            this.plusEquals.Name = "plusEquals";
            this.plusEquals.Size = new System.Drawing.Size(66, 46);
            this.plusEquals.TabIndex = 2;
            this.plusEquals.Text = "+=";
            // 
            // amountEnteredLabel
            // 
            this.amountEnteredLabel.AutoSize = true;
            this.amountEnteredLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountEnteredLabel.Location = new System.Drawing.Point(74, 76);
            this.amountEnteredLabel.Name = "amountEnteredLabel";
            this.amountEnteredLabel.Size = new System.Drawing.Size(312, 46);
            this.amountEnteredLabel.TabIndex = 1;
            this.amountEnteredLabel.Text = "<Amount Entered>";
            // 
            // allTimeTotalLabel
            // 
            this.allTimeTotalLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allTimeTotalLabel.Location = new System.Drawing.Point(16, 13);
            this.allTimeTotalLabel.Name = "allTimeTotalLabel";
            this.allTimeTotalLabel.Size = new System.Drawing.Size(322, 63);
            this.allTimeTotalLabel.TabIndex = 0;
            this.allTimeTotalLabel.Text = "<Total Amount>";
            this.allTimeTotalLabel.Click += new System.EventHandler(this.allTimeTotalLabel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button storeTransaction;
        private System.Windows.Forms.TextBox transactionInput;
        private System.Windows.Forms.Label transactionAmountLabel;
        private System.Windows.Forms.TextBox inputYear;
        private System.Windows.Forms.Button addYearMonth;
        private System.Windows.Forms.ComboBox chooseMonth;
        private System.Windows.Forms.Label newYearLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label allTimeTotalLabel;
        private System.Windows.Forms.Label plusEquals;
        private System.Windows.Forms.Label amountEnteredLabel;
    }
}

