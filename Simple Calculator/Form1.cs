namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ADD");
            comboBox1.Items.Add("SUB");
            comboBox1.Items.Add("MUL");
            comboBox1.Items.Add("DIV");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single num1, num2;
            Single ans;
            num1 = Convert.ToSingle(textBox1.Text);
            num2 = Convert.ToSingle(textBox2.Text);

            if(comboBox1.Text == "ADD")
            {
                ans = num1 + num2;
                MessageBox.Show("ADD = " + Convert.ToString(ans));
            }
            else if (comboBox1.Text == "SUB")
            {
                ans = num1 - num2;
                MessageBox.Show("SUB = " + Convert.ToString(ans));
            }
            else if (comboBox1.Text == "MUL")
            {
                ans = num1 * num2;
                MessageBox.Show("MUL = " + Convert.ToString(ans));
            }
            else if (comboBox1.Text == "DIV")
            {
                ans = num1 / num2;
                MessageBox.Show("DIV = " + Convert.ToString(ans));
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt16(e.KeyChar) == 8)
            {
                return;
            }
            if(e.KeyChar == '.' && textBox1.Text.IndexOf(".") >= 0)
            {
                e.Handled = true;
            }
            if(!char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}