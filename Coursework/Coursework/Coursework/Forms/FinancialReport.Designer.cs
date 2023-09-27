
namespace Coursework.Forms
{
    partial class FinancialReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FindExpensesButton = new System.Windows.Forms.Button();
            this.DateToLabel = new System.Windows.Forms.Label();
            this.DateFromLabel = new System.Windows.Forms.Label();
            this.DatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.ReportListView = new System.Windows.Forms.ListView();
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MonthlyIncome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MonthlyExpense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearlyIncome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearlyExpense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimePeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prediction = new System.Windows.Forms.Button();
            this.EnpensePaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatePickerFrom
            // 
            this.DatePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DatePickerFrom.Location = new System.Drawing.Point(68, 35);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(263, 23);
            this.DatePickerFrom.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FindExpensesButton);
            this.groupBox1.Controls.Add(this.DateToLabel);
            this.groupBox1.Controls.Add(this.DateFromLabel);
            this.groupBox1.Controls.Add(this.DatePickerTo);
            this.groupBox1.Controls.Add(this.DatePickerFrom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select A Time Period";
            // 
            // FindExpensesButton
            // 
            this.FindExpensesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FindExpensesButton.Location = new System.Drawing.Point(170, 141);
            this.FindExpensesButton.Name = "FindExpensesButton";
            this.FindExpensesButton.Size = new System.Drawing.Size(161, 25);
            this.FindExpensesButton.TabIndex = 4;
            this.FindExpensesButton.Text = "Find Expenses";
            this.FindExpensesButton.UseVisualStyleBackColor = true;
            this.FindExpensesButton.Click += new System.EventHandler(this.FindExpensesButton_Click);
            // 
            // DateToLabel
            // 
            this.DateToLabel.AutoSize = true;
            this.DateToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateToLabel.Location = new System.Drawing.Point(23, 96);
            this.DateToLabel.Name = "DateToLabel";
            this.DateToLabel.Size = new System.Drawing.Size(29, 17);
            this.DateToLabel.TabIndex = 3;
            this.DateToLabel.Text = "To:";
            // 
            // DateFromLabel
            // 
            this.DateFromLabel.AutoSize = true;
            this.DateFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DateFromLabel.Location = new System.Drawing.Point(20, 36);
            this.DateFromLabel.Name = "DateFromLabel";
            this.DateFromLabel.Size = new System.Drawing.Size(44, 17);
            this.DateFromLabel.TabIndex = 2;
            this.DateFromLabel.Text = "From:";
            // 
            // DatePickerTo
            // 
            this.DatePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DatePickerTo.Location = new System.Drawing.Point(68, 94);
            this.DatePickerTo.Name = "DatePickerTo";
            this.DatePickerTo.Size = new System.Drawing.Size(263, 23);
            this.DatePickerTo.TabIndex = 1;
            // 
            // ReportListView
            // 
            this.ReportListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Year,
            this.EnpensePaid,
            this.MonthlyIncome,
            this.MonthlyExpense,
            this.YearlyIncome,
            this.YearlyExpense,
            this.TimePeriod});
            this.ReportListView.HideSelection = false;
            this.ReportListView.Location = new System.Drawing.Point(410, 12);
            this.ReportListView.Name = "ReportListView";
            this.ReportListView.Size = new System.Drawing.Size(762, 612);
            this.ReportListView.TabIndex = 2;
            this.ReportListView.UseCompatibleStateImageBehavior = false;
            this.ReportListView.View = System.Windows.Forms.View.Details;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 50;
            // 
            // MonthlyIncome
            // 
            this.MonthlyIncome.Text = "Avg. Monthly Income";
            this.MonthlyIncome.Width = 123;
            // 
            // MonthlyExpense
            // 
            this.MonthlyExpense.Text = "Avg. Monthly Expense";
            this.MonthlyExpense.Width = 123;
            // 
            // YearlyIncome
            // 
            this.YearlyIncome.Text = "Yearly Income";
            this.YearlyIncome.Width = 100;
            // 
            // YearlyExpense
            // 
            this.YearlyExpense.Text = "Yearly Expense";
            this.YearlyExpense.Width = 100;
            // 
            // TimePeriod
            // 
            this.TimePeriod.Text = "No. of Months";
            this.TimePeriod.Width = 111;
            // 
            // Prediction
            // 
            this.Prediction.Location = new System.Drawing.Point(182, 257);
            this.Prediction.Name = "Prediction";
            this.Prediction.Size = new System.Drawing.Size(161, 26);
            this.Prediction.TabIndex = 3;
            this.Prediction.Text = "View Predictions";
            this.Prediction.UseVisualStyleBackColor = true;
            this.Prediction.Click += new System.EventHandler(this.Prediction_Click);
            // 
            // EnpensePaid
            // 
            this.EnpensePaid.Text = "First transaction Made";
            this.EnpensePaid.Width = 150;
            // 
            // FinancialReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.Prediction);
            this.Controls.Add(this.ReportListView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FinancialReport";
            this.Text = "Financial Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePickerFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DateToLabel;
        private System.Windows.Forms.Label DateFromLabel;
        private System.Windows.Forms.DateTimePicker DatePickerTo;
        private System.Windows.Forms.Button FindExpensesButton;
        private System.Windows.Forms.ListView ReportListView;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader MonthlyIncome;
        private System.Windows.Forms.ColumnHeader MonthlyExpense;
        private System.Windows.Forms.ColumnHeader YearlyIncome;
        private System.Windows.Forms.ColumnHeader YearlyExpense;
        private System.Windows.Forms.ColumnHeader TimePeriod;
        private System.Windows.Forms.Button Prediction;
        private System.Windows.Forms.ColumnHeader EnpensePaid;
    }
}