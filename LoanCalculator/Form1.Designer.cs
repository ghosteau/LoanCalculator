namespace LoanCalculator
{
    partial class myWindow
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
            principalLabel = new Label();
            principalInput = new TextBox();
            interestLabel = new Label();
            interestInput = new TextBox();
            interestDropbox = new ComboBox();
            interesttypeLabel = new Label();
            label2 = new Label();
            timeInput = new TextBox();
            compoundLabel = new Label();
            compoundInput = new TextBox();
            formulaLabel = new Label();
            calculatedInterestLabel = new Label();
            totalInterestOutput = new TextBox();
            calculationButton = new Button();
            totalLoanLabel = new Label();
            totalLoanOutput = new TextBox();
            SuspendLayout();
            // 
            // principalLabel
            // 
            principalLabel.AutoSize = true;
            principalLabel.Location = new Point(7, 10);
            principalLabel.Name = "principalLabel";
            principalLabel.Size = new Size(121, 15);
            principalLabel.TabIndex = 0;
            principalLabel.Text = "Principal cost of loan:";
            principalLabel.Click += label1_Click;
            // 
            // principalInput
            // 
            principalInput.Location = new Point(134, 7);
            principalInput.Name = "principalInput";
            principalInput.Size = new Size(100, 23);
            principalInput.TabIndex = 1;
            principalInput.TextChanged += textBox1_TextChanged;
            // 
            // interestLabel
            // 
            interestLabel.AutoSize = true;
            interestLabel.Location = new Point(7, 72);
            interestLabel.Name = "interestLabel";
            interestLabel.Size = new Size(179, 15);
            interestLabel.TabIndex = 2;
            interestLabel.Text = "Interest rate of loan (as decimal):";
            interestLabel.Click += label1_Click_1;
            // 
            // interestInput
            // 
            interestInput.Location = new Point(192, 69);
            interestInput.Name = "interestInput";
            interestInput.Size = new Size(100, 23);
            interestInput.TabIndex = 3;
            interestInput.TextChanged += textBox1_TextChanged_1;
            // 
            // interestDropbox
            // 
            interestDropbox.FormattingEnabled = true;
            interestDropbox.Items.AddRange(new object[] { "Simple", "Compound", "Continuous" });
            interestDropbox.Location = new Point(103, 200);
            interestDropbox.Name = "interestDropbox";
            interestDropbox.Size = new Size(100, 23);
            interestDropbox.TabIndex = 4;
            interestDropbox.SelectedIndexChanged += interestDropbox_SelectedIndexChanged;
            // 
            // interesttypeLabel
            // 
            interesttypeLabel.AutoSize = true;
            interesttypeLabel.Location = new Point(7, 203);
            interesttypeLabel.Name = "interesttypeLabel";
            interesttypeLabel.Size = new Size(90, 15);
            interesttypeLabel.TabIndex = 5;
            interesttypeLabel.Text = "Type of interest:";
            interesttypeLabel.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 144);
            label2.Name = "label2";
            label2.Size = new Size(423, 15);
            label2.TabIndex = 8;
            label2.Text = "The repayment period (you can use any unit of time -- most common is years):";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click_1;
            // 
            // timeInput
            // 
            timeInput.Location = new Point(436, 141);
            timeInput.Name = "timeInput";
            timeInput.Size = new Size(100, 23);
            timeInput.TabIndex = 9;
            timeInput.TextChanged += timeInput_TextChanged;
            // 
            // compoundLabel
            // 
            compoundLabel.AutoSize = true;
            compoundLabel.Location = new Point(7, 266);
            compoundLabel.Name = "compoundLabel";
            compoundLabel.Size = new Size(353, 15);
            compoundLabel.TabIndex = 10;
            compoundLabel.Text = "Amount of times compounded with respect to repayment period:";
            compoundLabel.Visible = false;
            compoundLabel.Click += label1_Click_3;
            // 
            // compoundInput
            // 
            compoundInput.Location = new Point(366, 263);
            compoundInput.Name = "compoundInput";
            compoundInput.Size = new Size(100, 23);
            compoundInput.TabIndex = 11;
            compoundInput.Visible = false;
            compoundInput.TextChanged += compoundInput_TextChanged;
            // 
            // formulaLabel
            // 
            formulaLabel.AutoSize = true;
            formulaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formulaLabel.Location = new Point(526, 7);
            formulaLabel.Name = "formulaLabel";
            formulaLabel.Size = new Size(261, 120);
            formulaLabel.TabIndex = 12;
            formulaLabel.Text = "Formulas for each:\r\n__________________________________________________\r\n\r\nSimple interest --> P * r * t\r\nContinuous compounding interest --> P * e^(rt)\r\nCompound interest --> P * (1 + r/n)^(nt)\r\n\r\n\r\n";
            formulaLabel.Click += label1_Click_4;
            // 
            // calculatedInterestLabel
            // 
            calculatedInterestLabel.AutoSize = true;
            calculatedInterestLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculatedInterestLabel.Location = new Point(25, 379);
            calculatedInterestLabel.Name = "calculatedInterestLabel";
            calculatedInterestLabel.Size = new Size(226, 25);
            calculatedInterestLabel.TabIndex = 13;
            calculatedInterestLabel.Text = "Total calculated interest:";
            calculatedInterestLabel.Click += label1_Click_5;
            // 
            // totalInterestOutput
            // 
            totalInterestOutput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalInterestOutput.Location = new Point(257, 376);
            totalInterestOutput.Name = "totalInterestOutput";
            totalInterestOutput.ReadOnly = true;
            totalInterestOutput.Size = new Size(97, 33);
            totalInterestOutput.TabIndex = 14;
            totalInterestOutput.TextChanged += totalInterestOutput_TextChanged;
            // 
            // calculationButton
            // 
            calculationButton.Location = new Point(40, 306);
            calculationButton.Name = "calculationButton";
            calculationButton.Size = new Size(194, 28);
            calculationButton.TabIndex = 15;
            calculationButton.Text = "Calculate";
            calculationButton.UseVisualStyleBackColor = true;
            calculationButton.Click += calculationButton_Click;
            // 
            // totalLoanLabel
            // 
            totalLoanLabel.AutoSize = true;
            totalLoanLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLoanLabel.Location = new Point(411, 379);
            totalLoanLabel.Name = "totalLoanLabel";
            totalLoanLabel.Size = new Size(195, 25);
            totalLoanLabel.TabIndex = 16;
            totalLoanLabel.Text = "Total calculated cost:";
            totalLoanLabel.Click += label1_Click_6;
            // 
            // totalLoanOutput
            // 
            totalLoanOutput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLoanOutput.Location = new Point(612, 376);
            totalLoanOutput.Name = "totalLoanOutput";
            totalLoanOutput.ReadOnly = true;
            totalLoanOutput.Size = new Size(97, 33);
            totalLoanOutput.TabIndex = 17;
            totalLoanOutput.TextChanged += totalLoanOutput_TextChanged;
            // 
            // myWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(totalLoanOutput);
            Controls.Add(totalLoanLabel);
            Controls.Add(calculationButton);
            Controls.Add(totalInterestOutput);
            Controls.Add(calculatedInterestLabel);
            Controls.Add(formulaLabel);
            Controls.Add(compoundInput);
            Controls.Add(compoundLabel);
            Controls.Add(timeInput);
            Controls.Add(label2);
            Controls.Add(interesttypeLabel);
            Controls.Add(interestDropbox);
            Controls.Add(interestInput);
            Controls.Add(interestLabel);
            Controls.Add(principalInput);
            Controls.Add(principalLabel);
            Name = "myWindow";
            Text = "Loan Calculator by Ghosteau";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label principalLabel;
        private TextBox principalInput;
        private Label interestLabel;
        private TextBox interestInput;
        private ComboBox interestDropbox;
        private Label interesttypeLabel;
        private Label label2;
        private TextBox timeInput;
        private Label compoundLabel;
        private TextBox compoundInput;
        private Label formulaLabel;
        private Label calculatedInterestLabel;
        private TextBox totalInterestOutput;
        private Button calculationButton;
        private Label totalLoanLabel;
        private TextBox totalLoanOutput;
    }
}
