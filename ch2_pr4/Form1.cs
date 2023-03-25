namespace ch2_pr4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream("D:\\college\\C# Practicals\\ch2_pr4\\wirte_read.txt" , System.IO.FileMode.OpenOrCreate);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs); 
            sw.WriteLine(textBox1.Text);
            MessageBox.Show("Data is written successfully!!!");
            sw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream("D:\\college\\C# Practicals\\ch2_pr4\\wirte_read.txt", System.IO.FileMode.OpenOrCreate);
            System.IO.StreamReader sr = new System.IO.StreamReader(fs);
            textBox2.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }
    }
}