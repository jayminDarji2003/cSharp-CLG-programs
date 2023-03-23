using Microsoft.VisualBasic;

namespace Loan_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Amt, InsAmt, RateOfInt;
            Int16 Installment;

            Amt = Convert.ToSingle(textBox1.Text);   // converting to single
            RateOfInt = Convert.ToSingle(textBox2.Text);  // converting to single
            Installment = Convert.ToInt16(textBox3.Text);  // converting to int16

            if(checkBox1.Checked == true)
            {
                InsAmt = Financial.Pmt(RateOfInt / (12 * 100),Installment,Amt,0,DueDate.BegOfPeriod);
            }
            else
            {
                InsAmt = Financial.Pmt(RateOfInt / (12 * 100), Installment, Amt, 0, DueDate.EndOfPeriod);
            }


            MessageBox.Show("Your Installment Amount is : " + Convert.ToString(InsAmt));

        }
    }
}