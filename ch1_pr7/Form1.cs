namespace ch1_pr7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("JAYMIN");
            listBox1.Items.Add("DEVANG");
            listBox1.Items.Add("SAHIL");
            listBox1.Items.Add("DEEP");
            listBox1.Items.Add("JEEL");
            listBox1.Items.Add("KARTIK");
            listBox1.Items.Add("SANJAY");
            listBox1.Items.Add("PREET");
            listBox1.Items.Add("CHINTAN");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Select any Items!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox1.SelectedItems.Count;

            if (n > 0)
            {
                for (i = 0; i < n; i++)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[0]);
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Select any items!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox1.Items.Count;
            
            for(i = 0; i < n; i++)
            {
                listBox2.Items.Add(listBox1.Items[0]);
                listBox1.Items.Remove(listBox1.Items[0]);
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Select any items!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox2.SelectedItems.Count;

            if (n > 0)
            {
                for (i = 0; i < n; i++)
                {
                    listBox1.Items.Add(listBox2.SelectedItems[0]);
                    listBox2.Items.Remove(listBox2.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Select any items!!!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox2.Items.Count;

            for(i = 0; i < n; i++)
            {
                listBox1.Items.Add(listBox2.Items[0]);
                listBox2.Items.Remove(listBox2.Items[0]);
            }
        }
    }
}