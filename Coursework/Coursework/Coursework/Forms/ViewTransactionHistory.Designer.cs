
namespace Coursework.Forms
{
    partial class ViewTransactionHistory
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
            this.TransactionListView = new System.Windows.Forms.ListView();
            this.SentFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SentTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactSC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactAccountNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsRecurring = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Schedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeSpace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TransactionListView
            // 
            this.TransactionListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.TransactionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SentFrom,
            this.SentTo,
            this.ContactName,
            this.ContactSC,
            this.ContactAccountNumber,
            this.IsRecurring,
            this.Date,
            this.Duration,
            this.Schedule,
            this.TimeSpace,
            this.Price});
            this.TransactionListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TransactionListView.HideSelection = false;
            this.TransactionListView.Location = new System.Drawing.Point(0, 0);
            this.TransactionListView.Name = "TransactionListView";
            this.TransactionListView.Size = new System.Drawing.Size(1184, 636);
            this.TransactionListView.TabIndex = 0;
            this.TransactionListView.UseCompatibleStateImageBehavior = false;
            this.TransactionListView.View = System.Windows.Forms.View.Details;
            // 
            // SentFrom
            // 
            this.SentFrom.Text = "Sent From";
            this.SentFrom.Width = 125;
            // 
            // SentTo
            // 
            this.SentTo.Text = "Sent To";
            this.SentTo.Width = 120;
            // 
            // ContactName
            // 
            this.ContactName.Text = "Recipient Name";
            this.ContactName.Width = 125;
            // 
            // ContactSC
            // 
            this.ContactSC.Text = "Recipient Sort Code";
            this.ContactSC.Width = 115;
            // 
            // ContactAccountNumber
            // 
            this.ContactAccountNumber.Text = "Recipient Account Number";
            this.ContactAccountNumber.Width = 140;
            // 
            // IsRecurring
            // 
            this.IsRecurring.Text = "Recurring Payment";
            this.IsRecurring.Width = 105;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 90;
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            // 
            // Schedule
            // 
            this.Schedule.Text = "Schedule";
            this.Schedule.Width = 80;
            // 
            // TimeSpace
            // 
            this.TimeSpace.Text = "Time Period";
            this.TimeSpace.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Amount";
            this.Price.Width = 120;
            // 
            // ViewTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.TransactionListView);
            this.Name = "ViewTransactionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Transaction History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView TransactionListView;
        private System.Windows.Forms.ColumnHeader SentFrom;
        private System.Windows.Forms.ColumnHeader SentTo;
        private System.Windows.Forms.ColumnHeader ContactName;
        private System.Windows.Forms.ColumnHeader ContactSC;
        private System.Windows.Forms.ColumnHeader ContactAccountNumber;
        private System.Windows.Forms.ColumnHeader IsRecurring;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader Schedule;
        private System.Windows.Forms.ColumnHeader TimeSpace;
        private System.Windows.Forms.ColumnHeader Price;
    }
}