
namespace Coursework.Forms
{
    partial class SendFinances
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
            this.Title = new System.Windows.Forms.Label();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.AccountBox = new System.Windows.Forms.ComboBox();
            this.ContactAccount = new System.Windows.Forms.ComboBox();
            this.ScheduledPayment = new System.Windows.Forms.RadioButton();
            this.ImmediatePayment = new System.Windows.Forms.RadioButton();
            this.RecurringPayment = new System.Windows.Forms.CheckBox();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.ScheduleSelector = new System.Windows.Forms.DateTimePicker();
            this.PaymentType = new System.Windows.Forms.Panel();
            this.cName_InfoLabel = new System.Windows.Forms.Label();
            this.expiryDate_InfoLabel = new System.Windows.Forms.Label();
            this.fName_ViewContact = new System.Windows.Forms.Label();
            this.aNumber_InfoLabel = new System.Windows.Forms.Label();
            this.lName_ViewContact = new System.Windows.Forms.Label();
            this.sCode_InfoLabel = new System.Windows.Forms.Label();
            this.sCode_ViewContact = new System.Windows.Forms.Label();
            this.lName_InfoLabel = new System.Windows.Forms.Label();
            this.aNumber_ViewContact = new System.Windows.Forms.Label();
            this.fName_InfoLabel = new System.Windows.Forms.Label();
            this.expiryDate_ViewContact = new System.Windows.Forms.Label();
            this.cardName_ViewContact = new System.Windows.Forms.Label();
            this.TimeIInterval = new System.Windows.Forms.Panel();
            this.Yearly = new System.Windows.Forms.RadioButton();
            this.Monthly = new System.Windows.Forms.RadioButton();
            this.EstimationLabel = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DurationPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Income = new System.Windows.Forms.RadioButton();
            this.Outgoing = new System.Windows.Forms.RadioButton();
            this.PaymentType.SuspendLayout();
            this.TimeIInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Duration)).BeginInit();
            this.DurationPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(79, 29);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(433, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Add a new Expense/Transaction";
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Location = new System.Drawing.Point(66, 87);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(105, 13);
            this.AccountLabel.TabIndex = 1;
            this.AccountLabel.Text = "Select your account:";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(368, 87);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(140, 13);
            this.ContactLabel.TabIndex = 2;
            this.ContactLabel.Text = "Select your desired Contact:";
            // 
            // AccountBox
            // 
            this.AccountBox.FormattingEnabled = true;
            this.AccountBox.Location = new System.Drawing.Point(27, 103);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(215, 21);
            this.AccountBox.TabIndex = 3;
            // 
            // ContactAccount
            // 
            this.ContactAccount.FormattingEnabled = true;
            this.ContactAccount.Location = new System.Drawing.Point(335, 103);
            this.ContactAccount.Name = "ContactAccount";
            this.ContactAccount.Size = new System.Drawing.Size(215, 21);
            this.ContactAccount.TabIndex = 4;
            this.ContactAccount.SelectedIndexChanged += new System.EventHandler(this.ContactAccount_SelectedIndexChanged);
            // 
            // ScheduledPayment
            // 
            this.ScheduledPayment.AutoSize = true;
            this.ScheduledPayment.Location = new System.Drawing.Point(21, 10);
            this.ScheduledPayment.Name = "ScheduledPayment";
            this.ScheduledPayment.Size = new System.Drawing.Size(120, 17);
            this.ScheduledPayment.TabIndex = 5;
            this.ScheduledPayment.TabStop = true;
            this.ScheduledPayment.Text = "Scheduled Payment";
            this.ScheduledPayment.UseVisualStyleBackColor = true;
            this.ScheduledPayment.CheckedChanged += new System.EventHandler(this.ScheduledPayment_CheckedChanged);
            // 
            // ImmediatePayment
            // 
            this.ImmediatePayment.AutoSize = true;
            this.ImmediatePayment.Location = new System.Drawing.Point(297, 10);
            this.ImmediatePayment.Name = "ImmediatePayment";
            this.ImmediatePayment.Size = new System.Drawing.Size(117, 17);
            this.ImmediatePayment.TabIndex = 6;
            this.ImmediatePayment.TabStop = true;
            this.ImmediatePayment.Text = "Immediate Payment";
            this.ImmediatePayment.UseVisualStyleBackColor = true;
            this.ImmediatePayment.CheckedChanged += new System.EventHandler(this.ImmediatePayment_CheckedChanged);
            // 
            // RecurringPayment
            // 
            this.RecurringPayment.AutoSize = true;
            this.RecurringPayment.Location = new System.Drawing.Point(221, 367);
            this.RecurringPayment.Name = "RecurringPayment";
            this.RecurringPayment.Size = new System.Drawing.Size(124, 17);
            this.RecurringPayment.TabIndex = 7;
            this.RecurringPayment.Text = "Is a reurring payment";
            this.RecurringPayment.UseVisualStyleBackColor = true;
            this.RecurringPayment.CheckedChanged += new System.EventHandler(this.RecurringPayment_CheckedChanged);
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.Location = new System.Drawing.Point(199, 313);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(169, 20);
            this.AmountTextbox.TabIndex = 8;
            this.AmountTextbox.TextChanged += new System.EventHandler(this.AmountTextbox_TextChanged);
            this.AmountTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTextbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Amount:";
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(198, 578);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(169, 23);
            this.Continue.TabIndex = 10;
            this.Continue.Text = "Make Payment";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // ScheduleSelector
            // 
            this.ScheduleSelector.Location = new System.Drawing.Point(112, 495);
            this.ScheduleSelector.Name = "ScheduleSelector";
            this.ScheduleSelector.Size = new System.Drawing.Size(169, 20);
            this.ScheduleSelector.TabIndex = 12;
            this.ScheduleSelector.Visible = false;
            this.ScheduleSelector.ValueChanged += new System.EventHandler(this.ScheduleSelector_ValueChanged);
            // 
            // PaymentType
            // 
            this.PaymentType.Controls.Add(this.ScheduledPayment);
            this.PaymentType.Controls.Add(this.ImmediatePayment);
            this.PaymentType.Location = new System.Drawing.Point(67, 442);
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.Size = new System.Drawing.Size(463, 36);
            this.PaymentType.TabIndex = 13;
            // 
            // cName_InfoLabel
            // 
            this.cName_InfoLabel.AutoSize = true;
            this.cName_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cName_InfoLabel.Location = new System.Drawing.Point(433, 169);
            this.cName_InfoLabel.Name = "cName_InfoLabel";
            this.cName_InfoLabel.Size = new System.Drawing.Size(16, 13);
            this.cName_InfoLabel.TabIndex = 38;
            this.cName_InfoLabel.Text = "...";
            // 
            // expiryDate_InfoLabel
            // 
            this.expiryDate_InfoLabel.AutoSize = true;
            this.expiryDate_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.expiryDate_InfoLabel.Location = new System.Drawing.Point(433, 141);
            this.expiryDate_InfoLabel.Name = "expiryDate_InfoLabel";
            this.expiryDate_InfoLabel.Size = new System.Drawing.Size(16, 13);
            this.expiryDate_InfoLabel.TabIndex = 37;
            this.expiryDate_InfoLabel.Text = "...";
            // 
            // fName_ViewContact
            // 
            this.fName_ViewContact.AutoSize = true;
            this.fName_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fName_ViewContact.Location = new System.Drawing.Point(36, 141);
            this.fName_ViewContact.Name = "fName_ViewContact";
            this.fName_ViewContact.Size = new System.Drawing.Size(60, 13);
            this.fName_ViewContact.TabIndex = 27;
            this.fName_ViewContact.Text = "First Name:";
            // 
            // aNumber_InfoLabel
            // 
            this.aNumber_InfoLabel.AutoSize = true;
            this.aNumber_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.aNumber_InfoLabel.Location = new System.Drawing.Point(282, 143);
            this.aNumber_InfoLabel.Name = "aNumber_InfoLabel";
            this.aNumber_InfoLabel.Size = new System.Drawing.Size(16, 13);
            this.aNumber_InfoLabel.TabIndex = 36;
            this.aNumber_InfoLabel.Text = "...";
            // 
            // lName_ViewContact
            // 
            this.lName_ViewContact.AutoSize = true;
            this.lName_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lName_ViewContact.Location = new System.Drawing.Point(31, 169);
            this.lName_ViewContact.Name = "lName_ViewContact";
            this.lName_ViewContact.Size = new System.Drawing.Size(61, 13);
            this.lName_ViewContact.TabIndex = 28;
            this.lName_ViewContact.Text = "Last Name:";
            // 
            // sCode_InfoLabel
            // 
            this.sCode_InfoLabel.AutoSize = true;
            this.sCode_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sCode_InfoLabel.Location = new System.Drawing.Point(259, 169);
            this.sCode_InfoLabel.Name = "sCode_InfoLabel";
            this.sCode_InfoLabel.Size = new System.Drawing.Size(16, 13);
            this.sCode_InfoLabel.TabIndex = 35;
            this.sCode_InfoLabel.Text = "...";
            // 
            // sCode_ViewContact
            // 
            this.sCode_ViewContact.AutoSize = true;
            this.sCode_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sCode_ViewContact.Location = new System.Drawing.Point(196, 169);
            this.sCode_ViewContact.Name = "sCode_ViewContact";
            this.sCode_ViewContact.Size = new System.Drawing.Size(57, 13);
            this.sCode_ViewContact.TabIndex = 29;
            this.sCode_ViewContact.Text = "Sort Code:";
            // 
            // lName_InfoLabel
            // 
            this.lName_InfoLabel.AutoSize = true;
            this.lName_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lName_InfoLabel.Location = new System.Drawing.Point(97, 169);
            this.lName_InfoLabel.Name = "lName_InfoLabel";
            this.lName_InfoLabel.Size = new System.Drawing.Size(16, 13);
            this.lName_InfoLabel.TabIndex = 34;
            this.lName_InfoLabel.Text = "...";
            // 
            // aNumber_ViewContact
            // 
            this.aNumber_ViewContact.AutoSize = true;
            this.aNumber_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.aNumber_ViewContact.Location = new System.Drawing.Point(186, 143);
            this.aNumber_ViewContact.Name = "aNumber_ViewContact";
            this.aNumber_ViewContact.Size = new System.Drawing.Size(90, 13);
            this.aNumber_ViewContact.TabIndex = 30;
            this.aNumber_ViewContact.Text = "Account Number:";
            // 
            // fName_InfoLabel
            // 
            this.fName_InfoLabel.AutoSize = true;
            this.fName_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fName_InfoLabel.Location = new System.Drawing.Point(102, 141);
            this.fName_InfoLabel.Name = "fName_InfoLabel";
            this.fName_InfoLabel.Size = new System.Drawing.Size(16, 13);
            this.fName_InfoLabel.TabIndex = 33;
            this.fName_InfoLabel.Text = "...";
            // 
            // expiryDate_ViewContact
            // 
            this.expiryDate_ViewContact.AutoSize = true;
            this.expiryDate_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.expiryDate_ViewContact.Location = new System.Drawing.Point(368, 141);
            this.expiryDate_ViewContact.Name = "expiryDate_ViewContact";
            this.expiryDate_ViewContact.Size = new System.Drawing.Size(64, 13);
            this.expiryDate_ViewContact.TabIndex = 31;
            this.expiryDate_ViewContact.Text = "Expiry Date:";
            // 
            // cardName_ViewContact
            // 
            this.cardName_ViewContact.AutoSize = true;
            this.cardName_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cardName_ViewContact.Location = new System.Drawing.Point(331, 169);
            this.cardName_ViewContact.Name = "cardName_ViewContact";
            this.cardName_ViewContact.Size = new System.Drawing.Size(96, 13);
            this.cardName_ViewContact.TabIndex = 32;
            this.cardName_ViewContact.Text = "Name on the Card:";
            // 
            // TimeIInterval
            // 
            this.TimeIInterval.Controls.Add(this.Yearly);
            this.TimeIInterval.Controls.Add(this.Monthly);
            this.TimeIInterval.Location = new System.Drawing.Point(67, 384);
            this.TimeIInterval.Name = "TimeIInterval";
            this.TimeIInterval.Size = new System.Drawing.Size(463, 37);
            this.TimeIInterval.TabIndex = 7;
            this.TimeIInterval.Visible = false;
            // 
            // Yearly
            // 
            this.Yearly.AutoSize = true;
            this.Yearly.Location = new System.Drawing.Point(297, 10);
            this.Yearly.Name = "Yearly";
            this.Yearly.Size = new System.Drawing.Size(54, 17);
            this.Yearly.TabIndex = 1;
            this.Yearly.TabStop = true;
            this.Yearly.Text = "Yearly";
            this.Yearly.UseVisualStyleBackColor = true;
            this.Yearly.CheckedChanged += new System.EventHandler(this.Yearly_CheckedChanged);
            // 
            // Monthly
            // 
            this.Monthly.AutoSize = true;
            this.Monthly.Location = new System.Drawing.Point(21, 10);
            this.Monthly.Name = "Monthly";
            this.Monthly.Size = new System.Drawing.Size(62, 17);
            this.Monthly.TabIndex = 0;
            this.Monthly.TabStop = true;
            this.Monthly.Text = "Monthly";
            this.Monthly.UseVisualStyleBackColor = true;
            this.Monthly.CheckedChanged += new System.EventHandler(this.Monthly_CheckedChanged);
            // 
            // EstimationLabel
            // 
            this.EstimationLabel.AutoSize = true;
            this.EstimationLabel.Location = new System.Drawing.Point(155, 537);
            this.EstimationLabel.Name = "EstimationLabel";
            this.EstimationLabel.Size = new System.Drawing.Size(102, 13);
            this.EstimationLabel.TabIndex = 39;
            this.EstimationLabel.Text = "Next payment date: ";
            this.EstimationLabel.Visible = false;
            // 
            // Duration
            // 
            this.Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Duration.Location = new System.Drawing.Point(64, 8);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(52, 20);
            this.Duration.TabIndex = 40;
            this.Duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Duration.ValueChanged += new System.EventHandler(this.Duration_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duration:";
            // 
            // DurationPanel
            // 
            this.DurationPanel.Controls.Add(this.Duration);
            this.DurationPanel.Controls.Add(this.label1);
            this.DurationPanel.Location = new System.Drawing.Point(339, 489);
            this.DurationPanel.Name = "DurationPanel";
            this.DurationPanel.Size = new System.Drawing.Size(128, 34);
            this.DurationPanel.TabIndex = 41;
            this.DurationPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Outgoing);
            this.panel1.Controls.Add(this.Income);
            this.panel1.Location = new System.Drawing.Point(67, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 42);
            this.panel1.TabIndex = 42;
            // 
            // Income
            // 
            this.Income.AutoSize = true;
            this.Income.Location = new System.Drawing.Point(21, 13);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(60, 17);
            this.Income.TabIndex = 0;
            this.Income.Text = "Income";
            this.Income.UseVisualStyleBackColor = true;
            // 
            // Outgoing
            // 
            this.Outgoing.AutoSize = true;
            this.Outgoing.Location = new System.Drawing.Point(297, 13);
            this.Outgoing.Name = "Outgoing";
            this.Outgoing.Size = new System.Drawing.Size(68, 17);
            this.Outgoing.TabIndex = 1;
            this.Outgoing.Text = "Outgoing";
            this.Outgoing.UseVisualStyleBackColor = true;
            // 
            // SendFinances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DurationPanel);
            this.Controls.Add(this.EstimationLabel);
            this.Controls.Add(this.TimeIInterval);
            this.Controls.Add(this.cName_InfoLabel);
            this.Controls.Add(this.expiryDate_InfoLabel);
            this.Controls.Add(this.fName_ViewContact);
            this.Controls.Add(this.aNumber_InfoLabel);
            this.Controls.Add(this.lName_ViewContact);
            this.Controls.Add(this.sCode_InfoLabel);
            this.Controls.Add(this.sCode_ViewContact);
            this.Controls.Add(this.lName_InfoLabel);
            this.Controls.Add(this.aNumber_ViewContact);
            this.Controls.Add(this.fName_InfoLabel);
            this.Controls.Add(this.expiryDate_ViewContact);
            this.Controls.Add(this.cardName_ViewContact);
            this.Controls.Add(this.PaymentType);
            this.Controls.Add(this.ScheduleSelector);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmountTextbox);
            this.Controls.Add(this.RecurringPayment);
            this.Controls.Add(this.ContactAccount);
            this.Controls.Add(this.AccountBox);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.Title);
            this.Name = "SendFinances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a new Expense/Transaction";
            this.PaymentType.ResumeLayout(false);
            this.PaymentType.PerformLayout();
            this.TimeIInterval.ResumeLayout(false);
            this.TimeIInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Duration)).EndInit();
            this.DurationPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.ComboBox AccountBox;
        private System.Windows.Forms.ComboBox ContactAccount;
        private System.Windows.Forms.RadioButton ScheduledPayment;
        private System.Windows.Forms.RadioButton ImmediatePayment;
        private System.Windows.Forms.CheckBox RecurringPayment;
        private System.Windows.Forms.TextBox AmountTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.DateTimePicker ScheduleSelector;
        private System.Windows.Forms.Panel PaymentType;
        private System.Windows.Forms.Label cName_InfoLabel;
        private System.Windows.Forms.Label expiryDate_InfoLabel;
        private System.Windows.Forms.Label fName_ViewContact;
        private System.Windows.Forms.Label aNumber_InfoLabel;
        private System.Windows.Forms.Label lName_ViewContact;
        private System.Windows.Forms.Label sCode_InfoLabel;
        private System.Windows.Forms.Label sCode_ViewContact;
        private System.Windows.Forms.Label lName_InfoLabel;
        private System.Windows.Forms.Label aNumber_ViewContact;
        private System.Windows.Forms.Label fName_InfoLabel;
        private System.Windows.Forms.Label expiryDate_ViewContact;
        private System.Windows.Forms.Label cardName_ViewContact;
        private System.Windows.Forms.Panel TimeIInterval;
        private System.Windows.Forms.RadioButton Yearly;
        private System.Windows.Forms.RadioButton Monthly;
        private System.Windows.Forms.Label EstimationLabel;
        private System.Windows.Forms.NumericUpDown Duration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel DurationPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Outgoing;
        private System.Windows.Forms.RadioButton Income;
    }
}