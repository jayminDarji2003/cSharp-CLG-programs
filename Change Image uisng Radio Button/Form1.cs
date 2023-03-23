namespace Change_Image_uisng_Radio_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("D:\\college\\C# Practicals\\Change Image uisng Radio Button\\flags images\\india.png");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("D:\\college\\C# Practicals\\Change Image uisng Radio Button\\flags images\\us.jpg");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("D:\\college\\C# Practicals\\Change Image uisng Radio Button\\flags images\\canada.png");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("D:\\college\\C# Practicals\\Change Image uisng Radio Button\\flags images\\london.jpg");
            }
        }
    }
}