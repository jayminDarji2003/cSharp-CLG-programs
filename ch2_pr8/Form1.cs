namespace ch2_pr8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // below is not working
            openFileDialog1.Filter = "All JPG files |*.jpg | All GIF files |*.gif | All PNG files |*.png";

            // i use this filter for open all files
           //openFileDialog1.Filter = "All files (*.*)|*.*";

            //open jpg file
           //openFileDialog1.Filter = "All JPG files (*.jpg)|*.jpg";

           // this will open all images 
           openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}