namespace aftervex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int val1 = 0;
            val1 = int.Parse(textBox1.Text);

            int val2 = 0;
            val2 = int.Parse(textBox2.Text);
            int sum = 0;

            if (val2 > val1)
            {
                for (int i = val1; i  <= val2; i ++)

                {
                   

                    sum += 1;
                }

                MessageBox.Show(sum.ToString());
            }
        }
    }
}
