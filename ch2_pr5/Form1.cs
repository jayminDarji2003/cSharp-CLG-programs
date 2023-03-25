namespace ch2_pr5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream("D:\\college\\C# Practicals\\ch2_pr5\\TextFile1.bin" , System.IO.FileMode.OpenOrCreate);
            System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs);
            Int16 empCode = Convert.ToInt16(textBox1.Text);
            string empName = Convert.ToString(textBox2.Text);
            Single salary = Convert.ToSingle(textBox3.Text);

            bw.Write(empCode);
            bw.Write(empName);
            bw.Write(salary);

            bw.Close();
            fs.Close();

            MessageBox.Show("Data is written in Binary file !!!!");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream("D:\\college\\C# Practicals\\ch2_pr5\\TextFile1.bin", System.IO.FileMode.OpenOrCreate);
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs);

            Int16 empCode = br.ReadInt16();
            string name = br.ReadString();
            Single salary = br.ReadSingle();

            textBox1.Text = Convert.ToString(empCode);
            textBox2.Text = name;
            textBox3.Text = Convert.ToString(salary);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}