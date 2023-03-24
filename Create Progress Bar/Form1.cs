namespace Create_Progress_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 25;
            }
            else
            {
                timer1.Enabled= false;
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
        }
    }
}