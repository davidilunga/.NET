
namespace Coursework.Forms
{
    partial class FinancialPrediction
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
            this.BackButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProjectionButton = new System.Windows.Forms.Button();
            this.DateToLabel = new System.Windows.Forms.Label();
            this.DateFromLabel = new System.Windows.Forms.Label();
            this.DatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.DatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.InformationPanel = new System.Windows.Forms.Panel();
            this.PredictionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.InformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 601);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(186, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back to Financial Report";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProjectionButton);
            this.groupBox1.Controls.Add(this.DateToLabel);
            this.groupBox1.Controls.Add(this.DateFromLabel);
            this.groupBox1.Controls.Add(this.DatePickerTo);
            this.groupBox1.Controls.Add(this.DatePickerFrom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select A Time Period";
            // 
            // ProjectionButton
            // 
            this.ProjectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ProjectionButton.Location = new System.Drawing.Point(189, 164);
            this.ProjectionButton.Name = "ProjectionButton";
            this.ProjectionButton.Size = new System.Drawing.Size(186, 25);
            this.ProjectionButton.TabIndex = 4;
            this.ProjectionButton.Text = "Calculate Financial Projection";
            this.ProjectionButton.UseVisualStyleBackColor = true;
            this.ProjectionButton.Click += new System.EventHandler(this.ProjectionButton_Click);
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
            // DatePickerFrom
            // 
            this.DatePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DatePickerFrom.Location = new System.Drawing.Point(68, 35);
            this.DatePickerFrom.Name = "DatePickerFrom";
            this.DatePickerFrom.Size = new System.Drawing.Size(263, 23);
            this.DatePickerFrom.TabIndex = 0;
            // 
            // InformationPanel
            // 
            this.InformationPanel.Controls.Add(this.PredictionLabel);
            this.InformationPanel.Location = new System.Drawing.Point(411, 13);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(761, 611);
            this.InformationPanel.TabIndex = 3;
            // 
            // PredictionLabel
            // 
            this.PredictionLabel.AutoSize = true;
            this.PredictionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PredictionLabel.Location = new System.Drawing.Point(18, 18);
            this.PredictionLabel.Name = "PredictionLabel";
            this.PredictionLabel.Size = new System.Drawing.Size(51, 20);
            this.PredictionLabel.TabIndex = 0;
            this.PredictionLabel.Text = "label1";
            this.PredictionLabel.Visible = false;
            // 
            // FinancialPrediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.InformationPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackButton);
            this.Name = "FinancialPrediction";
            this.Text = "Financial Prediction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ProjectionButton;
        private System.Windows.Forms.Label DateToLabel;
        private System.Windows.Forms.Label DateFromLabel;
        private System.Windows.Forms.DateTimePicker DatePickerTo;
        private System.Windows.Forms.DateTimePicker DatePickerFrom;
        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Label PredictionLabel;
    }
}