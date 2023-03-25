namespace ch2_pr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int fact(int n)
        {
            int ans, i;
            ans = 1;
            for(i=1; i<= n; i++)
            {
                ans = ans * i;
            }
            return ans;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            result = fact(Convert.ToInt16(textBox1.Text));
            MessageBox.Show("Factorial of " + textBox1.Text + " is " + Convert.ToString(result));
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int16 num = Convert.ToInt16(textBox1.Text);

            if(num % 2 == 0)
            {
                MessageBox.Show(textBox1.Text + " is Even");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show(textBox1.Text + " is Odd");
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}