
namespace Coursework.Forms
{
    partial class ViewContactInfo
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
            this.ContactInfoListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fName = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.aNumberTextBox = new System.Windows.Forms.TextBox();
            this.aNumber = new System.Windows.Forms.Label();
            this.sCodeTextBox = new System.Windows.Forms.TextBox();
            this.sCode = new System.Windows.Forms.Label();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.cardName = new System.Windows.Forms.Label();
            this.expiryDateTextBox = new System.Windows.Forms.TextBox();
            this.expiryDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cardName_ViewContact = new System.Windows.Forms.Label();
            this.expiryDate_ViewContact = new System.Windows.Forms.Label();
            this.aNumber_ViewContact = new System.Windows.Forms.Label();
            this.sCode_ViewContact = new System.Windows.Forms.Label();
            this.lName_ViewContact = new System.Windows.Forms.Label();
            this.fName_ViewContact = new System.Windows.Forms.Label();
            this.cName_InfoLabel = new System.Windows.Forms.Label();
            this.expiryDate_InfoLabel = new System.Windows.Forms.Label();
            this.aNumber_InfoLabel = new System.Windows.Forms.Label();
            this.sCode_InfoLabel = new System.Windows.Forms.Label();
            this.lName_InfoLabel = new System.Windows.Forms.Label();
            this.fName_InfoLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactInfoListView
            // 
            this.ContactInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FirstName,
            this.LastName});
            this.ContactInfoListView.FullRowSelect = true;
            this.ContactInfoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ContactInfoListView.HideSelection = false;
            this.ContactInfoListView.Location = new System.Drawing.Point(1, 1);
            this.ContactInfoListView.MultiSelect = false;
            this.ContactInfoListView.Name = "ContactInfoListView";
            this.ContactInfoListView.Size = new System.Drawing.Size(600, 630);
            this.ContactInfoListView.TabIndex = 0;
            this.ContactInfoListView.UseCompatibleStateImageBehavior = false;
            this.ContactInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 100;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 248;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 248;
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(671, 29);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(60, 13);
            this.fName.TabIndex = 1;
            this.fName.Text = "First Name:";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(776, 26);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(341, 20);
            this.fNameTextBox.TabIndex = 2;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(776, 62);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(341, 20);
            this.lNameTextBox.TabIndex = 4;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(671, 65);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(61, 13);
            this.lName.TabIndex = 3;
            this.lName.Text = "Last Name:";
            // 
            // aNumberTextBox
            // 
            this.aNumberTextBox.Location = new System.Drawing.Point(776, 133);
            this.aNumberTextBox.MaxLength = 8;
            this.aNumberTextBox.Name = "aNumberTextBox";
            this.aNumberTextBox.Size = new System.Drawing.Size(341, 20);
            this.aNumberTextBox.TabIndex = 8;
            this.aNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aNumberTextBox_KeyPress);
            // 
            // aNumber
            // 
            this.aNumber.AutoSize = true;
            this.aNumber.Location = new System.Drawing.Point(671, 136);
            this.aNumber.Name = "aNumber";
            this.aNumber.Size = new System.Drawing.Size(90, 13);
            this.aNumber.TabIndex = 7;
            this.aNumber.Text = "Account Number:";
            // 
            // sCodeTextBox
            // 
            this.sCodeTextBox.Location = new System.Drawing.Point(776, 97);
            this.sCodeTextBox.MaxLength = 8;
            this.sCodeTextBox.Name = "sCodeTextBox";
            this.sCodeTextBox.Size = new System.Drawing.Size(341, 20);
            this.sCodeTextBox.TabIndex = 6;
            this.sCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sCodeTextBox_KeyPress);
            // 
            // sCode
            // 
            this.sCode.AutoSize = true;
            this.sCode.Location = new System.Drawing.Point(671, 100);
            this.sCode.Name = "sCode";
            this.sCode.Size = new System.Drawing.Size(57, 13);
            this.sCode.TabIndex = 5;
            this.sCode.Text = "Sort Code:";
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.Location = new System.Drawing.Point(776, 206);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.Size = new System.Drawing.Size(341, 20);
            this.cardNameTextBox.TabIndex = 12;
            // 
            // cardName
            // 
            this.cardName.AutoSize = true;
            this.cardName.Location = new System.Drawing.Point(671, 209);
            this.cardName.Name = "cardName";
            this.cardName.Size = new System.Drawing.Size(96, 13);
            this.cardName.TabIndex = 11;
            this.cardName.Text = "Name on the Card:";
            // 
            // expiryDateTextBox
            // 
            this.expiryDateTextBox.Location = new System.Drawing.Point(776, 170);
            this.expiryDateTextBox.MaxLength = 5;
            this.expiryDateTextBox.Name = "expiryDateTextBox";
            this.expiryDateTextBox.Size = new System.Drawing.Size(341, 20);
            this.expiryDateTextBox.TabIndex = 10;
            this.expiryDateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expiryDateTextBox_KeyPress);
            // 
            // expiryDate
            // 
            this.expiryDate.AutoSize = true;
            this.expiryDate.Location = new System.Drawing.Point(671, 173);
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.Size = new System.Drawing.Size(64, 13);
            this.expiryDate.TabIndex = 9;
            this.expiryDate.Text = "Expiry Date:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add New Contact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddContact);
            // 
            // cardName_ViewContact
            // 
            this.cardName_ViewContact.AutoSize = true;
            this.cardName_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cardName_ViewContact.Location = new System.Drawing.Point(15, 224);
            this.cardName_ViewContact.Name = "cardName_ViewContact";
            this.cardName_ViewContact.Size = new System.Drawing.Size(142, 20);
            this.cardName_ViewContact.TabIndex = 20;
            this.cardName_ViewContact.Text = "Name on the Card:";
            // 
            // expiryDate_ViewContact
            // 
            this.expiryDate_ViewContact.AutoSize = true;
            this.expiryDate_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.expiryDate_ViewContact.Location = new System.Drawing.Point(15, 188);
            this.expiryDate_ViewContact.Name = "expiryDate_ViewContact";
            this.expiryDate_ViewContact.Size = new System.Drawing.Size(94, 20);
            this.expiryDate_ViewContact.TabIndex = 19;
            this.expiryDate_ViewContact.Text = "Expiry Date:";
            // 
            // aNumber_ViewContact
            // 
            this.aNumber_ViewContact.AutoSize = true;
            this.aNumber_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aNumber_ViewContact.Location = new System.Drawing.Point(15, 151);
            this.aNumber_ViewContact.Name = "aNumber_ViewContact";
            this.aNumber_ViewContact.Size = new System.Drawing.Size(132, 20);
            this.aNumber_ViewContact.TabIndex = 18;
            this.aNumber_ViewContact.Text = "Account Number:";
            // 
            // sCode_ViewContact
            // 
            this.sCode_ViewContact.AutoSize = true;
            this.sCode_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sCode_ViewContact.Location = new System.Drawing.Point(15, 115);
            this.sCode_ViewContact.Name = "sCode_ViewContact";
            this.sCode_ViewContact.Size = new System.Drawing.Size(85, 20);
            this.sCode_ViewContact.TabIndex = 17;
            this.sCode_ViewContact.Text = "Sort Code:";
            // 
            // lName_ViewContact
            // 
            this.lName_ViewContact.AutoSize = true;
            this.lName_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lName_ViewContact.Location = new System.Drawing.Point(15, 80);
            this.lName_ViewContact.Name = "lName_ViewContact";
            this.lName_ViewContact.Size = new System.Drawing.Size(90, 20);
            this.lName_ViewContact.TabIndex = 16;
            this.lName_ViewContact.Text = "Last Name:";
            // 
            // fName_ViewContact
            // 
            this.fName_ViewContact.AutoSize = true;
            this.fName_ViewContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fName_ViewContact.Location = new System.Drawing.Point(15, 44);
            this.fName_ViewContact.Name = "fName_ViewContact";
            this.fName_ViewContact.Size = new System.Drawing.Size(90, 20);
            this.fName_ViewContact.TabIndex = 15;
            this.fName_ViewContact.Text = "First Name:";
            // 
            // cName_InfoLabel
            // 
            this.cName_InfoLabel.AutoSize = true;
            this.cName_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cName_InfoLabel.Location = new System.Drawing.Point(160, 224);
            this.cName_InfoLabel.Name = "cName_InfoLabel";
            this.cName_InfoLabel.Size = new System.Drawing.Size(21, 20);
            this.cName_InfoLabel.TabIndex = 26;
            this.cName_InfoLabel.Text = "...";
            // 
            // expiryDate_InfoLabel
            // 
            this.expiryDate_InfoLabel.AutoSize = true;
            this.expiryDate_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.expiryDate_InfoLabel.Location = new System.Drawing.Point(111, 188);
            this.expiryDate_InfoLabel.Name = "expiryDate_InfoLabel";
            this.expiryDate_InfoLabel.Size = new System.Drawing.Size(21, 20);
            this.expiryDate_InfoLabel.TabIndex = 25;
            this.expiryDate_InfoLabel.Text = "...";
            // 
            // aNumber_InfoLabel
            // 
            this.aNumber_InfoLabel.AutoSize = true;
            this.aNumber_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aNumber_InfoLabel.Location = new System.Drawing.Point(150, 151);
            this.aNumber_InfoLabel.Name = "aNumber_InfoLabel";
            this.aNumber_InfoLabel.Size = new System.Drawing.Size(21, 20);
            this.aNumber_InfoLabel.TabIndex = 24;
            this.aNumber_InfoLabel.Text = "...";
            // 
            // sCode_InfoLabel
            // 
            this.sCode_InfoLabel.AutoSize = true;
            this.sCode_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sCode_InfoLabel.Location = new System.Drawing.Point(108, 115);
            this.sCode_InfoLabel.Name = "sCode_InfoLabel";
            this.sCode_InfoLabel.Size = new System.Drawing.Size(21, 20);
            this.sCode_InfoLabel.TabIndex = 23;
            this.sCode_InfoLabel.Text = "...";
            // 
            // lName_InfoLabel
            // 
            this.lName_InfoLabel.AutoSize = true;
            this.lName_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lName_InfoLabel.Location = new System.Drawing.Point(109, 80);
            this.lName_InfoLabel.Name = "lName_InfoLabel";
            this.lName_InfoLabel.Size = new System.Drawing.Size(21, 20);
            this.lName_InfoLabel.TabIndex = 22;
            this.lName_InfoLabel.Text = "...";
            // 
            // fName_InfoLabel
            // 
            this.fName_InfoLabel.AutoSize = true;
            this.fName_InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fName_InfoLabel.Location = new System.Drawing.Point(107, 44);
            this.fName_InfoLabel.Name = "fName_InfoLabel";
            this.fName_InfoLabel.Size = new System.Drawing.Size(21, 20);
            this.fName_InfoLabel.TabIndex = 21;
            this.fName_InfoLabel.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cName_InfoLabel);
            this.groupBox1.Controls.Add(this.expiryDate_InfoLabel);
            this.groupBox1.Controls.Add(this.fName_ViewContact);
            this.groupBox1.Controls.Add(this.aNumber_InfoLabel);
            this.groupBox1.Controls.Add(this.lName_ViewContact);
            this.groupBox1.Controls.Add(this.sCode_InfoLabel);
            this.groupBox1.Controls.Add(this.sCode_ViewContact);
            this.groupBox1.Controls.Add(this.lName_InfoLabel);
            this.groupBox1.Controls.Add(this.aNumber_ViewContact);
            this.groupBox1.Controls.Add(this.fName_InfoLabel);
            this.groupBox1.Controls.Add(this.expiryDate_ViewContact);
            this.groupBox1.Controls.Add(this.cardName_ViewContact);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(674, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 264);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Contact Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(762, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "No Current Contacts for this account.";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(757, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Get Selected Contact Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.cardName);
            this.Controls.Add(this.expiryDateTextBox);
            this.Controls.Add(this.expiryDate);
            this.Controls.Add(this.aNumberTextBox);
            this.Controls.Add(this.aNumber);
            this.Controls.Add(this.sCodeTextBox);
            this.Controls.Add(this.sCode);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.ContactInfoListView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewContactInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Contact Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ContactInfoListView;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox aNumberTextBox;
        private System.Windows.Forms.Label aNumber;
        private System.Windows.Forms.TextBox sCodeTextBox;
        private System.Windows.Forms.Label sCode;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.Label cardName;
        private System.Windows.Forms.TextBox expiryDateTextBox;
        private System.Windows.Forms.Label expiryDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cardName_ViewContact;
        private System.Windows.Forms.Label expiryDate_ViewContact;
        private System.Windows.Forms.Label aNumber_ViewContact;
        private System.Windows.Forms.Label sCode_ViewContact;
        private System.Windows.Forms.Label lName_ViewContact;
        private System.Windows.Forms.Label fName_ViewContact;
        private System.Windows.Forms.Label cName_InfoLabel;
        private System.Windows.Forms.Label expiryDate_InfoLabel;
        private System.Windows.Forms.Label aNumber_InfoLabel;
        private System.Windows.Forms.Label sCode_InfoLabel;
        private System.Windows.Forms.Label lName_InfoLabel;
        private System.Windows.Forms.Label fName_InfoLabel;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button button2;
    }
}