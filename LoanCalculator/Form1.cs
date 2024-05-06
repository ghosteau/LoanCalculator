using System.Diagnostics.CodeAnalysis;

namespace LoanCalculator
{
    public partial class myWindow : Form
    {
        private double myInterest; // interest rate
        private double myCost; // principal cost
        private int myTime; // t variable
        private int myCompound; // n variable
        private string selectedItem; // type of interest
        private double interestTotal; // total amount of interest accrued
        private double totalCost; // total cost including principal
        private string interestTotalString; // the toString of interestTotal
        private string totalCostString;

        public myWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // This is for the form -- do not edit
        {

        }

        private void label1_Click(object sender, EventArgs e) // This is the label for the principal cost
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Text box for principal cost
        {
            try
            {
                string userInput = principalInput.Text;
                double parsedInput = double.Parse(userInput);
                myCost = parsedInput;
            }

            catch (FormatException)
            {
                principalInput.Clear();
                MessageBox.Show("Please input a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click_1(object sender, EventArgs e) // This is the label for the interest decimal
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) // Text box for interest decimal
        {
            try
            {
                string userInput = interestInput.Text;
                double parsedInput = double.Parse(userInput);
                myInterest = parsedInput;
            }

            catch (FormatException)
            {
                interestInput.Clear();
                MessageBox.Show("Please input a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void interestDropbox_SelectedIndexChanged(object sender, EventArgs e) // This is the dropbox for choosing your type of interest
        {
            selectedItem = interestDropbox.SelectedItem.ToString();

            if (selectedItem.Equals("Compound"))
            {
                compoundLabel.Visible = true;
                compoundInput.Visible = true;
            }

            else
            {
                compoundLabel.Visible = false;
                compoundInput.Visible = false;
            }
        }

        private void label1_Click_2(object sender, EventArgs e) // Interest type dropbox label
        {

        }

        private void label2_Click_1(object sender, EventArgs e) // Repayment period label
        {

        }

        private void timeInput_TextChanged(object sender, EventArgs e) // Repayment period input
        {
            try
            {
                string userInput = timeInput.Text;
                int parsedInput = int.Parse(userInput);
                myTime = parsedInput;
            }

            catch (FormatException)
            {
                timeInput.Clear();
                MessageBox.Show("Please input a valid integer (no decimals)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_3(object sender, EventArgs e) // Compound interest -- times compounded label
        {

        }

        private void compoundInput_TextChanged(object sender, EventArgs e) // Compound interest -- times compounded input
        {
            try
            {
                string userInput = compoundInput.Text;
                int parsedInput = int.Parse(userInput);
                myCompound = parsedInput;
            }

            catch (FormatException)
            {
                compoundInput.Clear();
                MessageBox.Show("Please input a valid integer (no decimals)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_4(object sender, EventArgs e) // Formula label
        {

        }

        private void label1_Click_5(object sender, EventArgs e) // Calculated interest label
        {

        }

        private void CalculateInterest() // Used to calculate the interest
        {
            if (myInterest == 0 || myCost == 0 || myTime == 0 || selectedItem == null)
            {
                MessageBox.Show("Please input non-zero values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (selectedItem.Equals("Simple"))
            {
                interestTotal = myCost * myInterest * myTime;
            }

            else if (selectedItem.Equals("Compound"))
            {
                double myParenthesis = 1 + myInterest / myCompound;
                int myExponent = myCompound * myTime;
                double myFinalParenthesis = Math.Pow(myParenthesis, myExponent);
                interestTotal = myCost * myFinalParenthesis;
            }

            else if (selectedItem.Equals("Continuous"))
            {
                double myExponent = myInterest * myTime;
                double myFinalExponent = Math.Exp(myExponent);
                interestTotal = myCost * myFinalExponent;
            }

            interestTotal = Math.Round(interestTotal, 3);
            totalCost = myCost + interestTotal;
            totalCost = Math.Round(totalCost, 3);
            interestTotalString = interestTotal.ToString();
            totalCostString = totalCost.ToString();
            totalInterestOutput.Text = interestTotalString;
            totalLoanOutput.Text = totalCostString;
        }

        private void calculationButton_Click(object sender, EventArgs e) // The calculation button
        {
            CalculateInterest();
        }

        private void totalInterestOutput_TextChanged(object sender, EventArgs e) // Calculated interest output
        {
            interestTotalString = interestTotal.ToString();
            totalInterestOutput.Text = interestTotalString;
        }

        private void label1_Click_6(object sender, EventArgs e) // Total cost label
        {

        }

        private void totalLoanOutput_TextChanged(object sender, EventArgs e)
        {
            totalCostString = totalCost.ToString();
            totalLoanOutput.Text = totalCostString;
        }
    }
}
