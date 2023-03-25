namespace ch1_pr5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vowels = 0;
            int spaces = 0;
            int digits = 0;
            int symbols = 0;
            int consolant = 0;
            int i;

            for(i = 0; i < textBox1.Text.Length; i++)
            {
                char ch = char.ToLower(textBox1.Text[i]);
                if(char.IsDigit(ch))
                {
                    digits++;
                }
                else if(ch == ' ')
                {
                    spaces++;
                }
                else if(!char.IsLetterOrDigit(ch))
                {
                    symbols++;
                }
                else if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowels++;
                }
                else
                {
                    consolant++;
                }
            }

            String str = "There are \n" + vowels + " vowels\n" + spaces + " spaces\n" + consolant + " consolant\n" + digits + " digits\n" + symbols + " Special symbols";

            MessageBox.Show(str);


        }
    }
}